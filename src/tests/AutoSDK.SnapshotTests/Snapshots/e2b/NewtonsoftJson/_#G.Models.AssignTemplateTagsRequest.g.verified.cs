//HintName: G.Models.AssignTemplateTagsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignTemplateTagsRequest
    {
        /// <summary>
        /// Target template in "name:tag" format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public string Target { get; set; } = default!;

        /// <summary>
        /// Tags to assign to the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignTemplateTagsRequest" /> class.
        /// </summary>
        /// <param name="target">
        /// Target template in "name:tag" format
        /// </param>
        /// <param name="tags">
        /// Tags to assign to the template
        /// </param>
        public AssignTemplateTagsRequest(
            string target,
            global::System.Collections.Generic.IList<string> tags)
        {
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignTemplateTagsRequest" /> class.
        /// </summary>
        public AssignTemplateTagsRequest()
        {
        }
    }
}