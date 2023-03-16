namespace Domain.Constants.Commons
{
    public class MessageResponseConstant
    {

        #region CONSTANT CRUD OPERATION MESSAGE

        public const string MessageCreateSuccess = " has been created successfully.";
        public const string MessageReadSuccess = " has been loaded successfully.";
        public const string MessageUpdateSuccess = " has been updated successfully.";
        public const string MessageDeleteSuccess = " has been deleted successfully.";

        public const string MessageCreateFailed = " is fail to created.";
        public const string MessageReadFailed = " is fail to loaded.";
        public const string MessageUpdateFailed = " is fail to updated.";
        public const string MessageDeleteFailed = " is fail to deleted.";

        public const string MessageAlreadyExist = " is already exist.";

        #endregion END CONSTANT CRUD OPERATION MESSAGE


        #region CONSTANT USERS/ACCOUNT MESSAGE

        public const string MessageRegisterSuccess = "Registration succeed.";
        public const string MessageRegisterFailed = "Registration was failed.";

        public const string MessageAccountLocked = "Your account has been locked.";
        public const string MessageAccountUnlocked = "Your account has been unlocked.";

        public const string MessageUserActivationFailed = "Account activation is failed.";
        public const string MessageUserActivationSuccess = "Account has been activated successfully.";

        public const string MessageForgotPasswordSuccess = "Confirmation link to reset your password already sent to your email.";
        public const string MessageForgotPasswordFailed = "Forgot Password procedure is failed.";

        public const string MessageResetPasswordSuccess = "Your password has been reset successfully.";
        public const string MessageResetPasswordFailed = "Fail to reset your password.";

        #endregion END CONSTANT USERS/ACCOUNT MESSAGE


        #region CONSTANT ERROR MESSAGE

        public const string ConstructorParameterNull = "Constructor Parameter Is Null.";
        public const string MethodParameterNull = "Method Parameter Is Null.";
        public const string ParameterIsNull = "Parameter is Null.";

        public const string DataIsNotFound = "Data is not found.";
        public const string PermissionDenied = "Sorry!, You don't have permission.";

        public const string ErrorUnknown = "Something Went Wrong.";
        public const string InternalServerError = "Internal Server Error.";

        #endregion END CONSTANT ERROR MESSAGE



    }
}
