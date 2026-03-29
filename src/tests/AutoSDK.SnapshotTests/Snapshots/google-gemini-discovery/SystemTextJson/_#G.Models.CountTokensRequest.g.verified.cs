//HintName: G.Models.CountTokensRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Counts the number of tokens in the `prompt` sent to a model. Models may tokenize text differently, so each model may return a different `token_count`.
    /// </summary>
    public sealed partial class CountTokensRequest
    {
        /// <summary>
        /// Optional. The input given to the model as a prompt. This field is ignored when `generate_content_request` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::System.Collections.Generic.IList<global::G.Content>? Contents { get; set; }

        /// <summary>
        /// Request to generate a completion from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generateContentRequest")]
        public global::G.GenerateContentRequest? GenerateContentRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountTokensRequest" /> class.
        /// </summary>
        /// <param name="contents">
        /// Optional. The input given to the model as a prompt. This field is ignored when `generate_content_request` is set.
        /// </param>
        /// <param name="generateContentRequest">
        /// Request to generate a completion from the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountTokensRequest(
            global::System.Collections.Generic.IList<global::G.Content>? contents,
            global::G.GenerateContentRequest? generateContentRequest)
        {
            this.Contents = contents;
            this.GenerateContentRequest = generateContentRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountTokensRequest" /> class.
        /// </summary>
        public CountTokensRequest()
        {
        }
    }
}