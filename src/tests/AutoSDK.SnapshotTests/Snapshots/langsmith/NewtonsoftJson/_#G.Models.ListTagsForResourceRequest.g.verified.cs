//HintName: G.Models.ListTagsForResourceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTagsForResourceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ResourceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResourceType ResourceType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTagsForResourceRequest" /> class.
        /// </summary>
        /// <param name="resourceId"></param>
        /// <param name="resourceType"></param>
        public ListTagsForResourceRequest(
            global::System.Guid resourceId,
            global::G.ResourceType resourceType)
        {
            this.ResourceId = resourceId;
            this.ResourceType = resourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTagsForResourceRequest" /> class.
        /// </summary>
        public ListTagsForResourceRequest()
        {
        }
    }
}