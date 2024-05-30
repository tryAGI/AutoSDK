//HintName: G.Models.RunObjectIncompleteDetailsReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason why the run is incomplete. This will point to which specific token limit was reached over the course of the run.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunObjectIncompleteDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_completion_tokens")]
        MaxCompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_prompt_tokens")]
        MaxPromptTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunObjectIncompleteDetailsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunObjectIncompleteDetailsReason value)
        {
            return value switch
            {
                RunObjectIncompleteDetailsReason.MaxCompletionTokens => "max_completion_tokens",
                RunObjectIncompleteDetailsReason.MaxPromptTokens => "max_prompt_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunObjectIncompleteDetailsReason ToEnum(string value)
        {
            return value switch
            {
                "max_completion_tokens" => RunObjectIncompleteDetailsReason.MaxCompletionTokens,
                "max_prompt_tokens" => RunObjectIncompleteDetailsReason.MaxPromptTokens,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}