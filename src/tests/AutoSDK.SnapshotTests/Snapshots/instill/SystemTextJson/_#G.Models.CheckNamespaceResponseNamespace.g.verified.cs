//HintName: G.Models.CheckNamespaceResponseNamespace.g.cs

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
    public enum CheckNamespaceResponseNamespace
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
    public static class CheckNamespaceResponseNamespaceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckNamespaceResponseNamespace value)
        {
            return value switch
            {
                CheckNamespaceResponseNamespace.NamespaceAvailable => "NAMESPACE_AVAILABLE",
                CheckNamespaceResponseNamespace.NamespaceUser => "NAMESPACE_USER",
                CheckNamespaceResponseNamespace.NamespaceOrganization => "NAMESPACE_ORGANIZATION",
                CheckNamespaceResponseNamespace.NamespaceReserved => "NAMESPACE_RESERVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheckNamespaceResponseNamespace? ToEnum(string value)
        {
            return value switch
            {
                "NAMESPACE_AVAILABLE" => CheckNamespaceResponseNamespace.NamespaceAvailable,
                "NAMESPACE_USER" => CheckNamespaceResponseNamespace.NamespaceUser,
                "NAMESPACE_ORGANIZATION" => CheckNamespaceResponseNamespace.NamespaceOrganization,
                "NAMESPACE_RESERVED" => CheckNamespaceResponseNamespace.NamespaceReserved,
                _ => null,
            };
        }
    }
}