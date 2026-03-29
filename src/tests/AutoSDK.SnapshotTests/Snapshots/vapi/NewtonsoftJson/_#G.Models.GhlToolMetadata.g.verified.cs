//HintName: G.Models.GhlToolMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GhlToolMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locationId")]
        public string? LocationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GhlToolMetadata" /> class.
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="locationId"></param>
        public GhlToolMetadata(
            string? workflowId,
            string? locationId)
        {
            this.WorkflowId = workflowId;
            this.LocationId = locationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GhlToolMetadata" /> class.
        /// </summary>
        public GhlToolMetadata()
        {
        }
    }
}