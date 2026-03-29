//HintName: G.Models.DeleteTemplateTagsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTemplateTagsRequest
    {
        /// <summary>
        /// Name of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Tags to delete
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTemplateTagsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the template
        /// </param>
        /// <param name="tags">
        /// Tags to delete
        /// </param>
        public DeleteTemplateTagsRequest(
            string name,
            global::System.Collections.Generic.IList<string> tags)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTemplateTagsRequest" /> class.
        /// </summary>
        public DeleteTemplateTagsRequest()
        {
        }
    }
}