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
    [global::System.Runtime.Serialization.DataContract]
    public enum CheckNamespaceResponseNamespace
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NAMESPACE_AVAILABLE")]
        NAMESPACEAVAILABLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NAMESPACE_USER")]
        NAMESPACEUSER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NAMESPACE_ORGANIZATION")]
        NAMESPACEORGANIZATION,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NAMESPACE_RESERVED")]
        NAMESPACERESERVED,
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
                CheckNamespaceResponseNamespace.NAMESPACEAVAILABLE => "NAMESPACE_AVAILABLE",
                CheckNamespaceResponseNamespace.NAMESPACEUSER => "NAMESPACE_USER",
                CheckNamespaceResponseNamespace.NAMESPACEORGANIZATION => "NAMESPACE_ORGANIZATION",
                CheckNamespaceResponseNamespace.NAMESPACERESERVED => "NAMESPACE_RESERVED",
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
                "NAMESPACE_AVAILABLE" => CheckNamespaceResponseNamespace.NAMESPACEAVAILABLE,
                "NAMESPACE_USER" => CheckNamespaceResponseNamespace.NAMESPACEUSER,
                "NAMESPACE_ORGANIZATION" => CheckNamespaceResponseNamespace.NAMESPACEORGANIZATION,
                "NAMESPACE_RESERVED" => CheckNamespaceResponseNamespace.NAMESPACERESERVED,
                _ => null,
            };
        }
    }
}