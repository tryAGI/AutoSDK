//HintName: G.Models.OrganizationDashboardSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Organization dashboard for usage or invoices.
    /// </summary>
    public sealed partial class OrganizationDashboardSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddable_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmbeddableUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDashboardSchema" /> class.
        /// </summary>
        /// <param name="embeddableUrl"></param>
        public OrganizationDashboardSchema(
            string embeddableUrl)
        {
            this.EmbeddableUrl = embeddableUrl ?? throw new global::System.ArgumentNullException(nameof(embeddableUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDashboardSchema" /> class.
        /// </summary>
        public OrganizationDashboardSchema()
        {
        }
    }
}