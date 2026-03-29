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
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locationId")]
        public string? LocationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GhlToolMetadata" /> class.
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="locationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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