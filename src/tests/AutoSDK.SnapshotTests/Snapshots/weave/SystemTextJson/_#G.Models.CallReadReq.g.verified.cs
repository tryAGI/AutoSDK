//HintName: G.Models.CallReadReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallReadReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_costs")]
        public bool? IncludeCosts { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_storage_size")]
        public bool? IncludeStorageSize { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_total_storage_size")]
        public bool? IncludeTotalStorageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallReadReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="includeCosts">
        /// Default Value: false
        /// </param>
        /// <param name="includeStorageSize">
        /// Default Value: false
        /// </param>
        /// <param name="includeTotalStorageSize">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallReadReq(
            string projectId,
            string id,
            bool? includeCosts,
            bool? includeStorageSize,
            bool? includeTotalStorageSize)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IncludeCosts = includeCosts;
            this.IncludeStorageSize = includeStorageSize;
            this.IncludeTotalStorageSize = includeTotalStorageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallReadReq" /> class.
        /// </summary>
        public CallReadReq()
        {
        }
    }
}