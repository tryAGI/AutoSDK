//HintName: G.Models.OptimizePromptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to optimize a prompt.
    /// </summary>
    public sealed partial class OptimizePromptRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metaprompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metaprompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExampleRunWithFeedback> Examples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? OverallFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="metaprompt"></param>
        /// <param name="examples"></param>
        /// <param name="overallFeedback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptimizePromptRequest(
            string prompt,
            object metaprompt,
            global::System.Collections.Generic.IList<global::G.ExampleRunWithFeedback> examples,
            string? overallFeedback)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Metaprompt = metaprompt ?? throw new global::System.ArgumentNullException(nameof(metaprompt));
            this.Examples = examples ?? throw new global::System.ArgumentNullException(nameof(examples));
            this.OverallFeedback = overallFeedback ?? throw new global::System.ArgumentNullException(nameof(overallFeedback));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptRequest" /> class.
        /// </summary>
        public OptimizePromptRequest()
        {
        }
    }
}