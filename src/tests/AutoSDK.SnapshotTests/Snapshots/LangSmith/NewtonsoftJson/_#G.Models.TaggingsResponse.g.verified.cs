//HintName: G.Models.TaggingsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaggingsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TagKeyId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagValue { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_value_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TagValueId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TaggingsByResourceType Resources { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggingsResponse" /> class.
        /// </summary>
        /// <param name="tagKey"></param>
        /// <param name="tagKeyId"></param>
        /// <param name="tagValue"></param>
        /// <param name="tagValueId"></param>
        /// <param name="resources"></param>
        public TaggingsResponse(
            string tagKey,
            global::System.Guid tagKeyId,
            string tagValue,
            global::System.Guid tagValueId,
            global::G.TaggingsByResourceType resources)
        {
            this.TagKey = tagKey ?? throw new global::System.ArgumentNullException(nameof(tagKey));
            this.TagKeyId = tagKeyId;
            this.TagValue = tagValue ?? throw new global::System.ArgumentNullException(nameof(tagValue));
            this.TagValueId = tagValueId;
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggingsResponse" /> class.
        /// </summary>
        public TaggingsResponse()
        {
        }
    }
}