//HintName: G.Models.AgentRequestSttMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If set, determines whether speech to text should focus on latency or accuracy. Default to fast mode. When set to custom, custom_stt_config must be provided.<br/>
    /// Example: fast
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentRequestSttMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="accurate")]
        Accurate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestSttModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestSttMode value)
        {
            return value switch
            {
                AgentRequestSttMode.Accurate => "accurate",
                AgentRequestSttMode.Custom => "custom",
                AgentRequestSttMode.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestSttMode? ToEnum(string value)
        {
            return value switch
            {
                "accurate" => AgentRequestSttMode.Accurate,
                "custom" => AgentRequestSttMode.Custom,
                "fast" => AgentRequestSttMode.Fast,
                _ => null,
            };
        }
    }
}