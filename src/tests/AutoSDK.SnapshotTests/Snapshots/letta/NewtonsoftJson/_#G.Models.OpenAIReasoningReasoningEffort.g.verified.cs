//HintName: G.Models.OpenAIReasoningReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reasoning effort to use when generating text reasoning models<br/>
    /// Default Value: minimal
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIReasoningReasoningEffort
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xhigh")]
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIReasoningReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIReasoningReasoningEffort value)
        {
            return value switch
            {
                OpenAIReasoningReasoningEffort.High => "high",
                OpenAIReasoningReasoningEffort.Low => "low",
                OpenAIReasoningReasoningEffort.Medium => "medium",
                OpenAIReasoningReasoningEffort.Minimal => "minimal",
                OpenAIReasoningReasoningEffort.None => "none",
                OpenAIReasoningReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIReasoningReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => OpenAIReasoningReasoningEffort.High,
                "low" => OpenAIReasoningReasoningEffort.Low,
                "medium" => OpenAIReasoningReasoningEffort.Medium,
                "minimal" => OpenAIReasoningReasoningEffort.Minimal,
                "none" => OpenAIReasoningReasoningEffort.None,
                "xhigh" => OpenAIReasoningReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}