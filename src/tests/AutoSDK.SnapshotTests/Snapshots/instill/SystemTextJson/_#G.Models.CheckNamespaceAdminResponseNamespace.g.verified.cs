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
    public static class CheckNamespaceAdminResponseNamespaceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheckNamespaceAdminResponseNamespace value)
        {
            return value switch
            {
                CheckNamespaceAdminResponseNamespace.NAMESPACEAVAILABLE => "NAMESPACE_AVAILABLE",
                CheckNamespaceAdminResponseNamespace.NAMESPACEUSER => "NAMESPACE_USER",
                CheckNamespaceAdminResponseNamespace.NAMESPACEORGANIZATION => "NAMESPACE_ORGANIZATION",
                CheckNamespaceAdminResponseNamespace.NAMESPACERESERVED => "NAMESPACE_RESERVED",
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
                "NAMESPACE_AVAILABLE" => CheckNamespaceAdminResponseNamespace.NAMESPACEAVAILABLE,
                "NAMESPACE_USER" => CheckNamespaceAdminResponseNamespace.NAMESPACEUSER,
                "NAMESPACE_ORGANIZATION" => CheckNamespaceAdminResponseNamespace.NAMESPACEORGANIZATION,
                "NAMESPACE_RESERVED" => CheckNamespaceAdminResponseNamespace.NAMESPACERESERVED,
                _ => null,
            };
        }
    }
}