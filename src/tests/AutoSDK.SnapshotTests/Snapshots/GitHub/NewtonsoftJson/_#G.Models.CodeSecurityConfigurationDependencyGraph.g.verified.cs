//HintName: G.Models.CodeSecurityConfigurationDependencyGraph.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependency Graph
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityConfigurationDependencyGraph
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
    public static class CodeSecurityConfigurationDependencyGraphExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationDependencyGraph value)
        {
            return value switch
            {
                CodeSecurityConfigurationDependencyGraph.Enabled => "enabled",
                CodeSecurityConfigurationDependencyGraph.Disabled => "disabled",
                CodeSecurityConfigurationDependencyGraph.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationDependencyGraph? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationDependencyGraph.Enabled,
                "disabled" => CodeSecurityConfigurationDependencyGraph.Disabled,
                "not_set" => CodeSecurityConfigurationDependencyGraph.NotSet,
                _ => null,
            };
        }
    }
}