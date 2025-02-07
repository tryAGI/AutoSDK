//HintName: G.Models.SearchResultTextMatche.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultTextMatche
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_url")]
        public string? ObjectUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        public string? ObjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property")]
        public string? Property { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fragment")]
        public string? Fragment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public global::System.Collections.Generic.IList<global::G.SearchResultTextMatcheMatche>? Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultTextMatche" /> class.
        /// </summary>
        /// <param name="objectUrl"></param>
        /// <param name="objectType"></param>
        /// <param name="property"></param>
        /// <param name="fragment"></param>
        /// <param name="matches"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultTextMatche(
            string? objectUrl,
            string? objectType,
            string? property,
            string? fragment,
            global::System.Collections.Generic.IList<global::G.SearchResultTextMatcheMatche>? matches)
        {
            this.ObjectUrl = objectUrl;
            this.ObjectType = objectType;
            this.Property = property;
            this.Fragment = fragment;
            this.Matches = matches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultTextMatche" /> class.
        /// </summary>
        public SearchResultTextMatche()
        {
        }
    }
}