//HintName: G.Models.FinetuneCompletionRequestInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The per-line training example of a fine-tuning input file for completions models
    /// </summary>
    public sealed partial class FinetuneCompletionRequestInput
    {
        /// <summary>
        /// The input prompt for this training example.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The desired completion for this training example.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        public string? Completion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneCompletionRequestInput" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The input prompt for this training example.
        /// </param>
        /// <param name="completion">
        /// The desired completion for this training example.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetuneCompletionRequestInput(
            string? prompt,
            string? completion)
        {
            this.Prompt = prompt;
            this.Completion = completion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneCompletionRequestInput" /> class.
        /// </summary>
        public FinetuneCompletionRequestInput()
        {
        }
    }
}