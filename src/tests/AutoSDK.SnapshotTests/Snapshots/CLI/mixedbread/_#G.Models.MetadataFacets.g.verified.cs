//HintName: G.Models.MetadataFacets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents metadata facets for a store.
    /// </summary>
    public sealed partial class MetadataFacets
    {
        /// <summary>
        /// Metadata facets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object> Facets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFacets" /> class.
        /// </summary>
        /// <param name="facets">
        /// Metadata facets
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataFacets(
            global::System.Collections.Generic.Dictionary<string, object> facets)
        {
            this.Facets = facets ?? throw new global::System.ArgumentNullException(nameof(facets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFacets" /> class.
        /// </summary>
        public MetadataFacets()
        {
        }
    }
}