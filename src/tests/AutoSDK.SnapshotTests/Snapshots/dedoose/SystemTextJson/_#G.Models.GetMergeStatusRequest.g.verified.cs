//HintName: G.Models.GetMergeStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMergeStatusRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mergedProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MergedProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMergeStatusRequest" /> class.
        /// </summary>
        /// <param name="mergedProjectId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetMergeStatusRequest(
            global::System.Guid mergedProjectId)
        {
            this.MergedProjectId = mergedProjectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMergeStatusRequest" /> class.
        /// </summary>
        public GetMergeStatusRequest()
        {
        }
    }
}