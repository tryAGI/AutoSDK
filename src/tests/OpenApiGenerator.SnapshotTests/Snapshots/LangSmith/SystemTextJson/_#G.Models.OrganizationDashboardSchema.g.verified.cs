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
    }
}