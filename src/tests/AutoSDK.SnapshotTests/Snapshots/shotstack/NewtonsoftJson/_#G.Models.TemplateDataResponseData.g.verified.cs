//HintName: G.Models.TemplateDataResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response data returned with the [TemplateDataResponse](#tocs_templatedataresponse).
    /// </summary>
    public sealed partial class TemplateDataResponseData
    {
        /// <summary>
        /// The unique id of the template in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </summary>
        /// <example>f5493c17-d01f-445c-bb49-535fae65f219</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The template name.<br/>
        /// Example: My template
        /// </summary>
        /// <example>My template</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The owner id of the templates.<br/>
        /// Example: 5ca6hu7s9k
        /// </summary>
        /// <example>5ca6hu7s9k</example>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// An edit defines the arrangement of a video on a timeline, an audio edit or an image design and the output format. Video assets are automatically preprocessed to fix common compatibility issues before rendering. You can control preprocessing behavior using the `transcode` flag on video assets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Edit Template { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateDataResponseData" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique id of the template in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </param>
        /// <param name="name">
        /// The template name.<br/>
        /// Example: My template
        /// </param>
        /// <param name="owner">
        /// The owner id of the templates.<br/>
        /// Example: 5ca6hu7s9k
        /// </param>
        /// <param name="template">
        /// An edit defines the arrangement of a video on a timeline, an audio edit or an image design and the output format. Video assets are automatically preprocessed to fix common compatibility issues before rendering. You can control preprocessing behavior using the `transcode` flag on video assets.
        /// </param>
        public TemplateDataResponseData(
            string id,
            string name,
            string owner,
            global::G.Edit template)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateDataResponseData" /> class.
        /// </summary>
        public TemplateDataResponseData()
        {
        }
    }
}