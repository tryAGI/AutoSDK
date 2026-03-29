//HintName: G.Models.OpenAIChatRequestReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIChatRequestReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
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
        [global::System.Runtime.Serialization.EnumMember(Value="minimal")]
        Minimal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIChatRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatRequestReasoningEffort value)
        {
            return value switch
            {
                OpenAIChatRequestReasoningEffort.High => "high",
                OpenAIChatRequestReasoningEffort.Low => "low",
                OpenAIChatRequestReasoningEffort.Medium => "medium",
                OpenAIChatRequestReasoningEffort.Minimal => "minimal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIChatRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => OpenAIChatRequestReasoningEffort.High,
                "low" => OpenAIChatRequestReasoningEffort.Low,
                "medium" => OpenAIChatRequestReasoningEffort.Medium,
                "minimal" => OpenAIChatRequestReasoningEffort.Minimal,
                _ => null,
            };
        }
    }
}