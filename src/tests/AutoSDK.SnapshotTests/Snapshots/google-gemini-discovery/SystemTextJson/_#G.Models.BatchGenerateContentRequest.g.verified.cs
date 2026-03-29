//HintName: G.Models.BatchGenerateContentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for a `BatchGenerateContent` operation.
    /// </summary>
    public sealed partial class BatchGenerateContentRequest
    {
        /// <summary>
        /// A resource representing a batch of `GenerateContent` requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        public global::G.GenerateContentBatch? Batch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchGenerateContentRequest" /> class.
        /// </summary>
        /// <param name="batch">
        /// A resource representing a batch of `GenerateContent` requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchGenerateContentRequest(
            global::G.GenerateContentBatch? batch)
        {
            this.Batch = batch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchGenerateContentRequest" /> class.
        /// </summary>
        public BatchGenerateContentRequest()
        {
        }
    }
}