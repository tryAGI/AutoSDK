//HintName: G.Models.ListCatalogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetCatalogsResponse represents a response for getting all catalogs from users.
    /// </summary>
    public sealed partial class ListCatalogsResponse
    {
        /// <summary>
        /// The catalogs container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogs")]
        public global::System.Collections.Generic.IList<global::G.Catalog>? Catalogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}