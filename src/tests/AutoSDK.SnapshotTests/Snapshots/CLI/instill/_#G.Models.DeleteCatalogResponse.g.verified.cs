//HintName: G.Models.DeleteCatalogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DeleteCatalogResponse represents a response for deleting a catalog.
    /// </summary>
    public sealed partial class DeleteCatalogResponse
    {
        /// <summary>
        /// The catalog identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog")]
        public global::G.Catalog? Catalog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCatalogResponse" /> class.
        /// </summary>
        /// <param name="catalog">
        /// The catalog identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteCatalogResponse(
            global::G.Catalog? catalog)
        {
            this.Catalog = catalog;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCatalogResponse" /> class.
        /// </summary>
        public DeleteCatalogResponse()
        {
        }
    }
}