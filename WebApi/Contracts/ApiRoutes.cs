namespace WebApi.Contracts
{
    public static class ApiRoutes
    {
        public static class Authentication
        {
            public const string Login = "authentication/login";

            public const string Register = "authentication/register";
            
        }

        public static class Users
        {
            public const string Get = "users";

            public const string GetById = "user/{id}";

            public const string Update = "user/update";

            public const string Delete = "user/{id}/delete";

            public const string Inactived = "user/{id}/inactived";

            public const string Actived = "user/{id}/inactived";

            public const string Inactive = "user/{id}/inactive";

            public const string Remove = "user/{id}/remove";

            public const string ChangePassword = "user/{id}/change-password";


        }
    }
}