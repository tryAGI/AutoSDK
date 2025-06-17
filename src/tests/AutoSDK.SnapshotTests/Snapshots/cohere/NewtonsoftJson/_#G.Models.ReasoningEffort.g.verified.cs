//HintName: G.Models.ReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reasoning effort level of the model. This affects the model's performance and the time it takes to generate a response.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffort value)
        {
            return value switch
            {
                ReasoningEffort.Low => "low",
                ReasoningEffort.Medium => "medium",
                ReasoningEffort.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "low" => ReasoningEffort.Low,
                "medium" => ReasoningEffort.Medium,
                "high" => ReasoningEffort.High,
                _ => null,
            };
        }
    }
}