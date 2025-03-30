//HintName: G.Models.PromptEvaluationCriteriaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of evaluation criteria<br/>
    /// Default Value: prompt
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptEvaluationCriteriaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptEvaluationCriteriaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptEvaluationCriteriaType value)
        {
            return value switch
            {
                PromptEvaluationCriteriaType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptEvaluationCriteriaType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => PromptEvaluationCriteriaType.Prompt,
                _ => null,
            };
        }
    }
}