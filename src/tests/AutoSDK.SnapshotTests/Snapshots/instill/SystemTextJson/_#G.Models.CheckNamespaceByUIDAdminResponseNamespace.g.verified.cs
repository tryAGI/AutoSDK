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
    public enum CheckNamespaceByUIDAdminResponseNamespace
    {
        /// <summary>
        /// 
        /// </summary>
        NAMESPACEAVAILABLE,
        /// <summary>
        /// 
        /// </summary>
        NAMESPACEUSER,
        /// <summary>
        /// 
        /// </summary>
        NAMESPACEORGANIZATION,
        /// <summary>
        /// 
        /// </summary>
        NAMESPACERESERVED,
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
                CheckNamespaceByUIDAdminResponseNamespace.NAMESPACEAVAILABLE => "NAMESPACE_AVAILABLE",
                CheckNamespaceByUIDAdminResponseNamespace.NAMESPACEUSER => "NAMESPACE_USER",
                CheckNamespaceByUIDAdminResponseNamespace.NAMESPACEORGANIZATION => "NAMESPACE_ORGANIZATION",
                CheckNamespaceByUIDAdminResponseNamespace.NAMESPACERESERVED => "NAMESPACE_RESERVED",
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
                "NAMESPACE_AVAILABLE" => CheckNamespaceByUIDAdminResponseNamespace.NAMESPACEAVAILABLE,
                "NAMESPACE_USER" => CheckNamespaceByUIDAdminResponseNamespace.NAMESPACEUSER,
                "NAMESPACE_ORGANIZATION" => CheckNamespaceByUIDAdminResponseNamespace.NAMESPACEORGANIZATION,
                "NAMESPACE_RESERVED" => CheckNamespaceByUIDAdminResponseNamespace.NAMESPACERESERVED,
                _ => null,
            };
        }
    }
}