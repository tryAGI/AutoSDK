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
        /// The created catalog.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("catalog", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Catalog Catalog { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCatalogResponse" /> class.
        /// </summary>
        /// <param name="catalog">
        /// The created catalog.
        /// </param>
        public CreateCatalogResponse(
            global::G.Catalog catalog)
        {
            this.Catalog = catalog ?? throw new global::System.ArgumentNullException(nameof(catalog));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCatalogResponse" /> class.
        /// </summary>
        public CreateCatalogResponse()
        {
        }
    }
}