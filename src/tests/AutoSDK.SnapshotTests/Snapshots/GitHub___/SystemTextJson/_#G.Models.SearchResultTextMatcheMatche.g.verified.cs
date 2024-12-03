//HintName: G.Models.SearchResultTextMatcheMatche.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultTextMatcheMatche
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indices")]
        public global::System.Collections.Generic.IList<int>? Indices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultTextMatcheMatche" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="indices"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SearchResultTextMatcheMatche(
            string? text,
            global::System.Collections.Generic.IList<int>? indices)
        {
            this.Text = text;
            this.Indices = indices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultTextMatcheMatche" /> class.
        /// </summary>
        public SearchResultTextMatcheMatche()
        {
        }
    }
}