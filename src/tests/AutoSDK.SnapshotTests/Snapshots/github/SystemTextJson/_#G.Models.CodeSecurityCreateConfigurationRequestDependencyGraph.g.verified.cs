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
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
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
                CodeSecurityCreateConfigurationRequestDependencyGraph.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestDependencyGraph.Enabled => "enabled",
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
                "disabled" => CodeSecurityCreateConfigurationRequestDependencyGraph.Disabled,
                "enabled" => CodeSecurityCreateConfigurationRequestDependencyGraph.Enabled,
                "not_set" => CodeSecurityCreateConfigurationRequestDependencyGraph.NotSet,
                _ => null,
            };
        }
    }
}