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
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddable_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbeddableUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDashboardSchema" /> class.
        /// </summary>
        /// <param name="embeddableUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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