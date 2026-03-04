//HintName: G.Models.CheckNamespaceAdminResponseNamespace.g.cs

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
    public enum CheckNamespaceAdminResponseNamespace
    {
        /// <summary>
        /// Available.
        /// </summary>
        NamespaceAvailable,
        /// <summary>
        /// Namespace belongs to a user.
        /// </summary>
        NamespaceUser,
        /// <summary>
        /// Namespace belongs to an organization.
        /// </summary>
        NamespaceOrganization,
        /// <summary>
        /// Reserved.
        /// </summary>
        NamespaceReserved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheckNamespaceAdminResponseNamespaceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckNamespaceAdminResponseNamespace value)
        {
            return value switch
            {
                CheckNamespaceAdminResponseNamespace.NamespaceAvailable => "NAMESPACE_AVAILABLE",
                CheckNamespaceAdminResponseNamespace.NamespaceUser => "NAMESPACE_USER",
                CheckNamespaceAdminResponseNamespace.NamespaceOrganization => "NAMESPACE_ORGANIZATION",
                CheckNamespaceAdminResponseNamespace.NamespaceReserved => "NAMESPACE_RESERVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckNamespaceAdminResponseNamespace? ToEnum(string value)
        {
            return value switch
            {
                "NAMESPACE_AVAILABLE" => CheckNamespaceAdminResponseNamespace.NamespaceAvailable,
                "NAMESPACE_USER" => CheckNamespaceAdminResponseNamespace.NamespaceUser,
                "NAMESPACE_ORGANIZATION" => CheckNamespaceAdminResponseNamespace.NamespaceOrganization,
                "NAMESPACE_RESERVED" => CheckNamespaceAdminResponseNamespace.NamespaceReserved,
                _ => null,
            };
        }
    }
}