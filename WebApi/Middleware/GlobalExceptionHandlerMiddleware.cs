using Domain.Dtos.ApiResults;
using Domain.Exceptions;
using System.Net;
using System.Text.Json;

namespace WebApi.Middleware
{
    public class GlobalExceptionHandlerMiddleware : IMiddleware
    {

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }


        /// <summary>
        /// Handle Spesific Exceptions
        /// </summary>
        /// <param name="context">Http Request</param>
        /// <param name="ex">Exception Error</param>
        /// <returns>Error Message</returns>
        public static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            HttpStatusCode StatusCode;
            var exType = ex.GetType();

            string Messages;
            bool Success;

            if (exType == typeof(BadRequestException))
            {
                Messages = ex.Message;
                Success = false;
                StatusCode = HttpStatusCode.BadRequest;
            }
            else if (exType == typeof(NotFoundException))
            {
                Messages = ex.Message;
                Success = false;
                StatusCode = HttpStatusCode.NotFound;

            }
            else if (exType == typeof(AuthorizationException))
            {
                Messages = ex.Message;
                Success = false;
                StatusCode = HttpStatusCode.Unauthorized;

            }
            else
            {
                Messages = ex.Message;
                Success = false;
                StatusCode = HttpStatusCode.InternalServerError;

            }

            var result = new ResponseApiDto(Success, (int) StatusCode, Messages);

            var exResult = JsonSerializer.Serialize(result);
            context.Response.ContentType= "application/json";
            context.Response.StatusCode = (int) StatusCode;

            return context.Response.WriteAsync(exResult);
        }
    }
}
