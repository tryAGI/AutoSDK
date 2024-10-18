//HintName: G.Models.CodeSecurityCreateConfigurationRequestDependencyGraph.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependency Graph<br/>
    /// Default Value: enabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestDependencyGraph
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityCreateConfigurationRequestDependencyGraphExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestDependencyGraph value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestDependencyGraph.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestDependencyGraph.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestDependencyGraph.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestDependencyGraph? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestDependencyGraph.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestDependencyGraph.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestDependencyGraph.NotSet,
                _ => null,
            };
        }
    }
}