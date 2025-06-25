﻿//HintName: G.Models.UpdateCatalogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateCatalogResponse represents a response for updating a catalog.
    /// </summary>
    public sealed partial class UpdateCatalogResponse
    {
        /// <summary>
        /// The updated catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog")]
        public global::G.Catalog? Catalog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCatalogResponse" /> class.
        /// </summary>
        /// <param name="catalog">
        /// The updated catalog.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCatalogResponse(
            global::G.Catalog? catalog)
        {
            this.Catalog = catalog;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCatalogResponse" /> class.
        /// </summary>
        public UpdateCatalogResponse()
        {
        }
    }
}