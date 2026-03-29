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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_costs")]
        public bool? IncludeCosts { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_storage_size")]
        public bool? IncludeStorageSize { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_total_storage_size")]
        public bool? IncludeTotalStorageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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