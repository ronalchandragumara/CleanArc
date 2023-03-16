using System.Net;

namespace Domain.Dtos.ApiResults
{
    public class ResponseApiDto
    {
        public ResponseApiDto(bool success)
        {
            Messages = new List<string>();
            StatusCode = (int) HttpStatusCode.OK;
            Success = success;
        }

        public ResponseApiDto(bool success, string actionMessage)
        {
            Messages = new List<string>();

            StatusCode = (int)HttpStatusCode.OK;
            Success = success;
            Messages.Add(actionMessage);
        }

        public ResponseApiDto(bool success, object content)
        {
            Messages = new List<string>();

            StatusCode = (int)HttpStatusCode.OK;
            Success = success;
            Content = content;
        }

        public ResponseApiDto(bool success, int code, string actionMessage)
        {
            Messages = new List<string>();

            Success = success;
            StatusCode = code;
            Messages.Add(actionMessage);
        }

        public ResponseApiDto(bool success, int code, object content, string actionMessage)
        {
            Messages = new List<string>();

            Success = success;
            StatusCode = code;
            Content = content;
            Messages.Add(actionMessage);

        }

        public ResponseApiDto(bool success, int code, object content, List<string> actionMessages)
        {
            Success = success;
            StatusCode = code;
            Messages = actionMessages;
            Content = content;
        }


        public bool Success { get; set; }

        public int StatusCode { get; set; }

        public List<string>? Messages { get; set; }

        public object? Content { get; set; }
    }
}
