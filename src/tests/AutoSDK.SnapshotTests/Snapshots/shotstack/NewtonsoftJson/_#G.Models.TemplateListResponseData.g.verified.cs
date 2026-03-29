//HintName: G.Models.TemplateListResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response data returned with the [TemplateListResponse](#tocs_templatelistresponse).
    /// </summary>
    public sealed partial class TemplateListResponseData
    {
        /// <summary>
        /// The owner id of the templates.<br/>
        /// Example: 5ca6hu7s9k
        /// </summary>
        /// <example>5ca6hu7s9k</example>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// The list of templates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templates", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TemplateListResponseItem> Templates { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponseData" /> class.
        /// </summary>
        /// <param name="owner">
        /// The owner id of the templates.<br/>
        /// Example: 5ca6hu7s9k
        /// </param>
        /// <param name="templates">
        /// The list of templates.
        /// </param>
        public TemplateListResponseData(
            string owner,
            global::System.Collections.Generic.IList<global::G.TemplateListResponseItem> templates)
        {
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Templates = templates ?? throw new global::System.ArgumentNullException(nameof(templates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponseData" /> class.
        /// </summary>
        public TemplateListResponseData()
        {
        }
    }
}