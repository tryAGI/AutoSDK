//HintName: G.Models.AgentsRemoveMetricFromAgentCartesiaVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: 2025-04-16
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsRemoveMetricFromAgentCartesiaVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2024-06-10")]
        x20240610,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2024-11-13")]
        x20241113,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2025-04-16")]
        x20250416,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2025-11-04")]
        x20251104,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsRemoveMetricFromAgentCartesiaVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsRemoveMetricFromAgentCartesiaVersion value)
        {
            return value switch
            {
                AgentsRemoveMetricFromAgentCartesiaVersion.x20240610 => "2024-06-10",
                AgentsRemoveMetricFromAgentCartesiaVersion.x20241113 => "2024-11-13",
                AgentsRemoveMetricFromAgentCartesiaVersion.x20250416 => "2025-04-16",
                AgentsRemoveMetricFromAgentCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsRemoveMetricFromAgentCartesiaVersion? ToEnum(string value)
        {
            return value switch
            {
                "2024-06-10" => AgentsRemoveMetricFromAgentCartesiaVersion.x20240610,
                "2024-11-13" => AgentsRemoveMetricFromAgentCartesiaVersion.x20241113,
                "2025-04-16" => AgentsRemoveMetricFromAgentCartesiaVersion.x20250416,
                "2025-11-04" => AgentsRemoveMetricFromAgentCartesiaVersion.x20251104,
                _ => null,
            };
        }
    }
}