//HintName: G.Models.SimulationRunTargetAssistantType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of target
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimulationRunTargetAssistantType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunTargetAssistantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunTargetAssistantType value)
        {
            return value switch
            {
                SimulationRunTargetAssistantType.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunTargetAssistantType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => SimulationRunTargetAssistantType.Assistant,
                _ => null,
            };
        }
    }
}