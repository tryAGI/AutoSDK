//HintName: G.Models.LLMResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information from the LLM response.
    /// </summary>
    public sealed partial class LLMResponse
    {
        /// <summary>
        /// Number of tokens in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokenCount")]
        public int? PromptTokenCount { get; set; }

        /// <summary>
        /// Number of tokens in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseTokenCount")]
        public int? ResponseTokenCount { get; set; }

        /// <summary>
        /// The LLM output text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Output { get; set; }

        /// <summary>
        /// Stream output chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streamOutput")]
        public global::System.Collections.Generic.IList<string>? StreamOutput { get; set; }

        /// <summary>
        /// Async stream output chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asyncStreamOutput")]
        public global::System.Collections.Generic.IList<string>? AsyncStreamOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponse" /> class.
        /// </summary>
        /// <param name="output">
        /// The LLM output text.
        /// </param>
        /// <param name="promptTokenCount">
        /// Number of tokens in the prompt.
        /// </param>
        /// <param name="responseTokenCount">
        /// Number of tokens in the response.
        /// </param>
        /// <param name="streamOutput">
        /// Stream output chunks.
        /// </param>
        /// <param name="asyncStreamOutput">
        /// Async stream output chunks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMResponse(
            string output,
            int? promptTokenCount,
            int? responseTokenCount,
            global::System.Collections.Generic.IList<string>? streamOutput,
            global::System.Collections.Generic.IList<string>? asyncStreamOutput)
        {
            this.PromptTokenCount = promptTokenCount;
            this.ResponseTokenCount = responseTokenCount;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.StreamOutput = streamOutput;
            this.AsyncStreamOutput = asyncStreamOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponse" /> class.
        /// </summary>
        public LLMResponse()
        {
        }
    }
}