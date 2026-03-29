//HintName: G.Models.Permission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Each permission permits a certain type of operation on an object in the system<br/>
    /// Permissions can be assigned to to objects on an individual basis, or grouped into roles
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Permission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create")]
        Create,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="create_acls")]
        CreateAcls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete")]
        Delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="delete_acls")]
        DeleteAcls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read_acls")]
        ReadAcls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update")]
        Update,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update_acls")]
        UpdateAcls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Permission value)
        {
            return value switch
            {
                Permission.Create => "create",
                Permission.CreateAcls => "create_acls",
                Permission.Delete => "delete",
                Permission.DeleteAcls => "delete_acls",
                Permission.Read => "read",
                Permission.ReadAcls => "read_acls",
                Permission.Update => "update",
                Permission.UpdateAcls => "update_acls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Permission? ToEnum(string value)
        {
            return value switch
            {
                "create" => Permission.Create,
                "create_acls" => Permission.CreateAcls,
                "delete" => Permission.Delete,
                "delete_acls" => Permission.DeleteAcls,
                "read" => Permission.Read,
                "read_acls" => Permission.ReadAcls,
                "update" => Permission.Update,
                "update_acls" => Permission.UpdateAcls,
                _ => null,
            };
        }
    }
}