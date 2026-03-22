//HintName: G.Models.OrgsUpdateRequestDefaultRepositoryPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default permission level members have for organization repositories.<br/>
    /// Default Value: read
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsUpdateRequestDefaultRepositoryPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsUpdateRequestDefaultRepositoryPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsUpdateRequestDefaultRepositoryPermission value)
        {
            return value switch
            {
                OrgsUpdateRequestDefaultRepositoryPermission.Admin => "admin",
                OrgsUpdateRequestDefaultRepositoryPermission.None => "none",
                OrgsUpdateRequestDefaultRepositoryPermission.Read => "read",
                OrgsUpdateRequestDefaultRepositoryPermission.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsUpdateRequestDefaultRepositoryPermission? ToEnum(string value)
        {
            return value switch
            {
                "admin" => OrgsUpdateRequestDefaultRepositoryPermission.Admin,
                "none" => OrgsUpdateRequestDefaultRepositoryPermission.None,
                "read" => OrgsUpdateRequestDefaultRepositoryPermission.Read,
                "write" => OrgsUpdateRequestDefaultRepositoryPermission.Write,
                _ => null,
            };
        }
    }
}