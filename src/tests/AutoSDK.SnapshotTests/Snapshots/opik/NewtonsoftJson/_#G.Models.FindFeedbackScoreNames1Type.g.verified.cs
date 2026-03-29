//HintName: G.Models.FindFeedbackScoreNames1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FindFeedbackScoreNames1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="general")]
        General,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="guardrail")]
        Guardrail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FindFeedbackScoreNames1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindFeedbackScoreNames1Type value)
        {
            return value switch
            {
                FindFeedbackScoreNames1Type.General => "general",
                FindFeedbackScoreNames1Type.Guardrail => "guardrail",
                FindFeedbackScoreNames1Type.Llm => "llm",
                FindFeedbackScoreNames1Type.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindFeedbackScoreNames1Type? ToEnum(string value)
        {
            return value switch
            {
                "general" => FindFeedbackScoreNames1Type.General,
                "guardrail" => FindFeedbackScoreNames1Type.Guardrail,
                "llm" => FindFeedbackScoreNames1Type.Llm,
                "tool" => FindFeedbackScoreNames1Type.Tool,
                _ => null,
            };
        }
    }
}