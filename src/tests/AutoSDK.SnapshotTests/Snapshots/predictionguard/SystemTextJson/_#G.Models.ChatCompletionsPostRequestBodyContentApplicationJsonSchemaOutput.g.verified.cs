//HintName: G.Models.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options to affect the output of the response.
    /// </summary>
    public sealed partial class ChatCompletionsPostRequestBodyContentApplicationJsonSchemaOutput
    {
        /// <summary>
        /// Set to true to turn on factuality processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("factuality")]
        public bool? Factuality { get; set; }

        /// <summary>
        /// Set to true to turn on toxicity processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toxicity")]
        public bool? Toxicity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaOutput" /> class.
        /// </summary>
        /// <param name="factuality">
        /// Set to true to turn on factuality processing.
        /// </param>
        /// <param name="toxicity">
        /// Set to true to turn on toxicity processing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaOutput(
            bool? factuality,
            bool? toxicity)
        {
            this.Factuality = factuality;
            this.Toxicity = toxicity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostRequestBodyContentApplicationJsonSchemaOutput" /> class.
        /// </summary>
        public ChatCompletionsPostRequestBodyContentApplicationJsonSchemaOutput()
        {
        }
    }
}