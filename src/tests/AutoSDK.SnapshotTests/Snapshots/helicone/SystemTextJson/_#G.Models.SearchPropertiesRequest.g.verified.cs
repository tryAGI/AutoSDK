//HintName: G.Models.SearchPropertiesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchPropertiesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchTerm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SearchTerm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPropertiesRequest" /> class.
        /// </summary>
        /// <param name="searchTerm"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPropertiesRequest(
            string searchTerm)
        {
            this.SearchTerm = searchTerm ?? throw new global::System.ArgumentNullException(nameof(searchTerm));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPropertiesRequest" /> class.
        /// </summary>
        public SearchPropertiesRequest()
        {
        }
    }
}