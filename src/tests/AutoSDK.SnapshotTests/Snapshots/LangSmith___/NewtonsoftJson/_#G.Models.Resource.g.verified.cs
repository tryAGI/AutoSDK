//HintName: G.Models.Resource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Resource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagging_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TaggingId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResourceName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ResourceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource" /> class.
        /// </summary>
        /// <param name="taggingId"></param>
        /// <param name="resourceName"></param>
        /// <param name="resourceId"></param>
        public Resource(
            global::System.Guid taggingId,
            string resourceName,
            global::System.Guid resourceId)
        {
            this.TaggingId = taggingId;
            this.ResourceName = resourceName ?? throw new global::System.ArgumentNullException(nameof(resourceName));
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource" /> class.
        /// </summary>
        public Resource()
        {
        }
    }
}