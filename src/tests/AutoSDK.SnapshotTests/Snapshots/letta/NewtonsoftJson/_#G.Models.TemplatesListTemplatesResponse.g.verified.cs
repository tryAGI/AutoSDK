//HintName: G.Models.TemplatesListTemplatesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesListTemplatesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templates", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TemplatesListTemplatesResponseTemplate> Templates { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_next_page", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNextPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesListTemplatesResponse" /> class.
        /// </summary>
        /// <param name="templates"></param>
        /// <param name="hasNextPage"></param>
        public TemplatesListTemplatesResponse(
            global::System.Collections.Generic.IList<global::G.TemplatesListTemplatesResponseTemplate> templates,
            bool hasNextPage)
        {
            this.Templates = templates ?? throw new global::System.ArgumentNullException(nameof(templates));
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesListTemplatesResponse" /> class.
        /// </summary>
        public TemplatesListTemplatesResponse()
        {
        }
    }
}