//HintName: G.Models.ReportChunkBatchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportChunkBatchRequest
    {
        /// <summary>
        /// The list of chunks successfully uploaded that you're reporting to the platform. Report only after receiving an ETag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CompletedChunk> CompletedChunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportChunkBatchRequest" /> class.
        /// </summary>
        /// <param name="completedChunks">
        /// The list of chunks successfully uploaded that you're reporting to the platform. Report only after receiving an ETag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportChunkBatchRequest(
            global::System.Collections.Generic.IList<global::G.CompletedChunk> completedChunks)
        {
            this.CompletedChunks = completedChunks ?? throw new global::System.ArgumentNullException(nameof(completedChunks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportChunkBatchRequest" /> class.
        /// </summary>
        public ReportChunkBatchRequest()
        {
        }
    }
}