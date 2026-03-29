//HintName: G.Models.TemplatesListTemplateVersionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesListTemplateVersionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TemplatesListTemplateVersionsResponseVersion> Versions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_next_page", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNextPage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesListTemplateVersionsResponse" /> class.
        /// </summary>
        /// <param name="versions"></param>
        /// <param name="hasNextPage"></param>
        /// <param name="totalCount"></param>
        public TemplatesListTemplateVersionsResponse(
            global::System.Collections.Generic.IList<global::G.TemplatesListTemplateVersionsResponseVersion> versions,
            bool hasNextPage,
            double totalCount)
        {
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.HasNextPage = hasNextPage;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesListTemplateVersionsResponse" /> class.
        /// </summary>
        public TemplatesListTemplateVersionsResponse()
        {
        }
    }
}