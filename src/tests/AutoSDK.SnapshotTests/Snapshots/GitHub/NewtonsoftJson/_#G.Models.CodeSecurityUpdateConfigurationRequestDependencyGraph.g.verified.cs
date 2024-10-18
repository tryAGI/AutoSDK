//HintName: G.Models.CodeSecurityUpdateConfigurationRequestDependencyGraph.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependency Graph
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityUpdateConfigurationRequestDependencyGraph
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_set")]
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityUpdateConfigurationRequestDependencyGraphExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestDependencyGraph value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestDependencyGraph.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestDependencyGraph.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestDependencyGraph.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestDependencyGraph? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateConfigurationRequestDependencyGraph.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestDependencyGraph.Disabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestDependencyGraph.NotSet,
                _ => null,
            };
        }
    }
}