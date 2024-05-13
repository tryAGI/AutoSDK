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
}