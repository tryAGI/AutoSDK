//HintName: G.Models.AgentDefinitionSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentDefinitionSource
    {
        /// <summary>
        /// 
        /// </summary>
        Cli,
        /// <summary>
        /// 
        /// </summary>
        Ui,
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Template,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentDefinitionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentDefinitionSource value)
        {
            return value switch
            {
                AgentDefinitionSource.Cli => "cli",
                AgentDefinitionSource.Ui => "ui",
                AgentDefinitionSource.Api => "api",
                AgentDefinitionSource.Template => "template",
                AgentDefinitionSource.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentDefinitionSource? ToEnum(string value)
        {
            return value switch
            {
                "cli" => AgentDefinitionSource.Cli,
                "ui" => AgentDefinitionSource.Ui,
                "api" => AgentDefinitionSource.Api,
                "template" => AgentDefinitionSource.Template,
                "unknown" => AgentDefinitionSource.Unknown,
                _ => null,
            };
        }
    }
}