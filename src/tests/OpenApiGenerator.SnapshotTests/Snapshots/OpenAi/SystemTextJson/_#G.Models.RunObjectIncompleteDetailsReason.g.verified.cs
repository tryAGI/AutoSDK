//HintName: G.Models.RunObjectIncompleteDetailsReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason why the run is incomplete. This will point to which specific token limit was reached over the course of the run.
    /// </summary>
    public abstract class RunObjectIncompleteDetailsReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string MaxCompletionTokens = "max_completion_tokens";
        /// <summary>
        /// 
        /// </summary>
        public const string MaxPromptTokens = "max_prompt_tokens";
    }
}