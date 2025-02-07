//HintName: G.Models.ListPipelineIDsByConnectionIDResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListPipelineIDsByConnectionIDResponse contains a paginated list of integrations.
    /// </summary>
    public sealed partial class ListPipelineIDsByConnectionIDResponse
    {
        /// <summary>
        /// A list of pipeline IDs matching the request parameters.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineIds")]
        public global::System.Collections.Generic.IList<string>? PipelineIds { get; set; }

        /// <summary>
        /// Next page token.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of items.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineIDsByConnectionIDResponse" /> class.
        /// </summary>
        /// <param name="pipelineIds">
        /// A list of pipeline IDs matching the request parameters.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of items.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPipelineIDsByConnectionIDResponse(
            global::System.Collections.Generic.IList<string>? pipelineIds,
            string? nextPageToken,
            int? totalSize)
        {
            this.PipelineIds = pipelineIds;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineIDsByConnectionIDResponse" /> class.
        /// </summary>
        public ListPipelineIDsByConnectionIDResponse()
        {
        }
    }
}