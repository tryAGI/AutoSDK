//HintName: G.Models.AclListPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Each permission permits a certain type of operation on an object in the system<br/>
    /// Permissions can be assigned to to objects on an individual basis, or grouped into roles
    /// </summary>
    public enum AclListPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        CreateAcls,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        DeleteAcls,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        ReadAcls,
        /// <summary>
        /// 
        /// </summary>
        Update,
        /// <summary>
        /// 
        /// </summary>
        UpdateAcls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AclListPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AclListPermission value)
        {
            return value switch
            {
                AclListPermission.Create => "create",
                AclListPermission.CreateAcls => "create_acls",
                AclListPermission.Delete => "delete",
                AclListPermission.DeleteAcls => "delete_acls",
                AclListPermission.Read => "read",
                AclListPermission.ReadAcls => "read_acls",
                AclListPermission.Update => "update",
                AclListPermission.UpdateAcls => "update_acls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AclListPermission? ToEnum(string value)
        {
            return value switch
            {
                "create" => AclListPermission.Create,
                "create_acls" => AclListPermission.CreateAcls,
                "delete" => AclListPermission.Delete,
                "delete_acls" => AclListPermission.DeleteAcls,
                "read" => AclListPermission.Read,
                "read_acls" => AclListPermission.ReadAcls,
                "update" => AclListPermission.Update,
                "update_acls" => AclListPermission.UpdateAcls,
                _ => null,
            };
        }
    }
}