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
        [global::Newtonsoft.Json.JsonProperty("searchTerm", Required = global::Newtonsoft.Json.Required.Always)]
        public string SearchTerm { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPropertiesRequest" /> class.
        /// </summary>
        /// <param name="searchTerm"></param>
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