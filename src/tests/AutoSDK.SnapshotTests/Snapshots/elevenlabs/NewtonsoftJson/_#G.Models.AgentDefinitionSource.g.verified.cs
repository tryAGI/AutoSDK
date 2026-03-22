//HintName: G.Models.AgentDefinitionSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentDefinitionSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api")]
        Api,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cli")]
        Cli,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="template")]
        Template,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ui")]
        Ui,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
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
                AgentDefinitionSource.Api => "api",
                AgentDefinitionSource.Cli => "cli",
                AgentDefinitionSource.Template => "template",
                AgentDefinitionSource.Ui => "ui",
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
                "api" => AgentDefinitionSource.Api,
                "cli" => AgentDefinitionSource.Cli,
                "template" => AgentDefinitionSource.Template,
                "ui" => AgentDefinitionSource.Ui,
                "unknown" => AgentDefinitionSource.Unknown,
                _ => null,
            };
        }
    }
}