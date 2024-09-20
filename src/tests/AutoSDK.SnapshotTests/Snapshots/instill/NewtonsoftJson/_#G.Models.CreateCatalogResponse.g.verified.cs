//HintName: G.Models.CreateCatalogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateCatalogResponse represents a response for creating a catalog.
    /// </summary>
    public sealed partial class CreateCatalogResponse
    {
        /// <summary>
        /// Catalog represents a catalog.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("catalog")]
        public global::G.Catalog? Catalog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}