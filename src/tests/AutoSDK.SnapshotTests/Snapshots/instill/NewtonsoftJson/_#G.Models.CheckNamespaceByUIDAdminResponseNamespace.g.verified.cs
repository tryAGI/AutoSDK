//HintName: G.Models.CheckNamespaceByUIDAdminResponseNamespace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Namespace contains information about the availability of a namespace.<br/>
    ///  - NAMESPACE_AVAILABLE: Available.<br/>
    ///  - NAMESPACE_USER: Namespace belongs to a user.<br/>
    ///  - NAMESPACE_ORGANIZATION: Namespace belongs to an organization.<br/>
    ///  - NAMESPACE_RESERVED: Reserved.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CheckNamespaceByUIDAdminResponseNamespace
    {
        /// <summary>
        /// Available.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NAMESPACE_AVAILABLE")]
        NamespaceAvailable,
        /// <summary>
        /// Namespace belongs to an organization.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NAMESPACE_ORGANIZATION")]
        NamespaceOrganization,
        /// <summary>
        /// Reserved.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NAMESPACE_RESERVED")]
        NamespaceReserved,
        /// <summary>
        /// Namespace belongs to a user.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NAMESPACE_USER")]
        NamespaceUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckNamespaceByUIDAdminResponseNamespaceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckNamespaceByUIDAdminResponseNamespace value)
        {
            return value switch
            {
                CheckNamespaceByUIDAdminResponseNamespace.NamespaceAvailable => "NAMESPACE_AVAILABLE",
                CheckNamespaceByUIDAdminResponseNamespace.NamespaceOrganization => "NAMESPACE_ORGANIZATION",
                CheckNamespaceByUIDAdminResponseNamespace.NamespaceReserved => "NAMESPACE_RESERVED",
                CheckNamespaceByUIDAdminResponseNamespace.NamespaceUser => "NAMESPACE_USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckNamespaceByUIDAdminResponseNamespace? ToEnum(string value)
        {
            return value switch
            {
                "NAMESPACE_AVAILABLE" => CheckNamespaceByUIDAdminResponseNamespace.NamespaceAvailable,
                "NAMESPACE_ORGANIZATION" => CheckNamespaceByUIDAdminResponseNamespace.NamespaceOrganization,
                "NAMESPACE_RESERVED" => CheckNamespaceByUIDAdminResponseNamespace.NamespaceReserved,
                "NAMESPACE_USER" => CheckNamespaceByUIDAdminResponseNamespace.NamespaceUser,
                _ => null,
            };
        }
    }
}