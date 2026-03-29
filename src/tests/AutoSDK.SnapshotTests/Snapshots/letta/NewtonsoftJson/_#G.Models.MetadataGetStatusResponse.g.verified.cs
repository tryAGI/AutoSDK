//HintName: G.Models.MetadataGetStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataGetStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_project_id")]
        public string? CurrentProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataGetStatusResponse" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        public MetadataGetStatusResponse(
            string? currentProjectId)
        {
            this.CurrentProjectId = currentProjectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataGetStatusResponse" /> class.
        /// </summary>
        public MetadataGetStatusResponse()
        {
        }
    }
}