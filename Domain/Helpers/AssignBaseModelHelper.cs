using System.Reflection;

namespace Domain.Helpers
{
    public static class AssignBaseModelHelper
    {
        public static T AssignCreateModel<T>(T model, DateTime serverTime, string userIdLogin, string userFrom = "", long? unixServerTime = null) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            PropertyInfo? createdTime = props.FirstOrDefault(x => x.Name == "CreatedTime");
            createdTime?.SetValue(model, serverTime, null);

            PropertyInfo? createdBy = props.FirstOrDefault(x => x.Name == "CreatedBy");
            createdBy?.SetValue(model, userIdLogin, null);

            if (!string.IsNullOrEmpty(userFrom))
            {
                PropertyInfo? createdFrom = props.FirstOrDefault(a => a.Name == "CreatedFrom");
                createdFrom?.SetValue(model, userFrom, null);
            }

            if (unixServerTime > 0)
            {
                PropertyInfo? unixCreatedTime = props.FirstOrDefault(a => a.Name == "UnixCreatedTime");
                unixCreatedTime?.SetValue(model, unixServerTime, null);
            }



            return model;
        }

        public static T AssignUpdateModel<T>(T model, DateTime serverTime, string userIdLogin = "", string userFrom = "", long? unixServerTime = null) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            PropertyInfo? modifiedTime = props.FirstOrDefault(x => x.Name == "ModifiedTime");
            modifiedTime?.SetValue(model, serverTime, null);

            PropertyInfo? modifiedBy = props.FirstOrDefault(x => x.Name == "ModifiedBy");
            modifiedBy?.SetValue(model, userIdLogin, null);

            if (!string.IsNullOrEmpty(userFrom))
            {
                PropertyInfo? modifiedFrom = props.FirstOrDefault(a => a.Name == "ModifiedFrom");
                modifiedFrom?.SetValue(model, userFrom, null);
            }

            if (unixServerTime > 0)
            {
                PropertyInfo? unixModifiedTime = props.FirstOrDefault(a => a.Name == "UnixModifiedTime");

                unixModifiedTime?.SetValue(model, unixServerTime, null);

            }

            return model;
        }

        public static T AssignDeleteModel<T>(T model, DateTime serverTime, string userIdLogin = "", string userFrom = "", long? unixServerTime = null) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            PropertyInfo? modifiedTime = props.FirstOrDefault(x => x.Name == "ModifiedTime");
            modifiedTime?.SetValue(model, serverTime, null);

            PropertyInfo? modifiedBy = props.FirstOrDefault(x => x.Name == "ModifiedBy");
            modifiedBy?.SetValue(model, userIdLogin, null);

            PropertyInfo? recordDeleted = props.FirstOrDefault(x => x.Name == "Deleted");
            recordDeleted?.SetValue(model, true, null);

            if (!string.IsNullOrEmpty(userFrom))
            {
                PropertyInfo? modifiedFrom = props.FirstOrDefault(a => a.Name == "ModifiedFrom");
                modifiedFrom?.SetValue(model, userFrom, null);
            }

            if (unixServerTime > 0)
            {
                PropertyInfo? unixModifiedTime = props.FirstOrDefault(a => a.Name == "UnixModifiedTime");
                unixModifiedTime?.SetValue(model, unixServerTime, null);
            }

            return model;
        }
    }
}
