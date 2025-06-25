//HintName: G.Models.SearchCategoriesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchCategoriesResponse
    {
        /// <summary>
        /// The list of games or categories that match the query. The list is empty if there are no matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Category> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCategoriesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of games or categories that match the query. The list is empty if there are no matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchCategoriesResponse(
            global::System.Collections.Generic.IList<global::G.Category> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCategoriesResponse" /> class.
        /// </summary>
        public SearchCategoriesResponse()
        {
        }
    }
}