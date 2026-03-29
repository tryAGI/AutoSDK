//HintName: G.Models.TemplateListResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The individual template item returned with the  [TemplateListResponseData](#tocs_templatelistresponsedata) templates list.
    /// </summary>
    public sealed partial class TemplateListResponseItem
    {
        /// <summary>
        /// The unique id of the template in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </summary>
        /// <example>f5493c17-d01f-445c-bb49-535fae65f219</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The template name<br/>
        /// Example: My template
        /// </summary>
        /// <example>My template</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The time the template was created.<br/>
        /// Example: 2022-06-10T12:50:21.455Z
        /// </summary>
        /// <example>2022-06-10T12:50:21.455Z</example>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public string? Created { get; set; }

        /// <summary>
        /// The time the template was last updated.<br/>
        /// Example: 2022-06-22T08:24:30.168Z
        /// </summary>
        /// <example>2022-06-22T08:24:30.168Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated")]
        public string? Updated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique id of the template in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </param>
        /// <param name="name">
        /// The template name<br/>
        /// Example: My template
        /// </param>
        /// <param name="created">
        /// The time the template was created.<br/>
        /// Example: 2022-06-10T12:50:21.455Z
        /// </param>
        /// <param name="updated">
        /// The time the template was last updated.<br/>
        /// Example: 2022-06-22T08:24:30.168Z
        /// </param>
        public TemplateListResponseItem(
            string id,
            string name,
            string? created,
            string? updated)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Created = created;
            this.Updated = updated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponseItem" /> class.
        /// </summary>
        public TemplateListResponseItem()
        {
        }
    }
}