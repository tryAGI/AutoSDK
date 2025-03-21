//HintName: G.Models.ReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **o-series models only** <br/>
    /// Constrains effort on reasoning for <br/>
    /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
    /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
    /// reasoning effort can result in faster responses and fewer tokens used<br/>
    /// on reasoning in a response.<br/>
    /// Default Value: medium
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