//HintName: G.Models.DeleteCatalogResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.Catalog>? Catalog { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}