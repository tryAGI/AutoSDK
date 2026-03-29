//HintName: G.Models.OpenAPIListVersionData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIListVersionData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::System.Collections.Generic.IList<global::G.OpenAPIVersionMetaInfo>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIListVersionData" /> class.
        /// </summary>
        /// <param name="hasMore"></param>
        /// <param name="items"></param>
        /// <param name="nextPageToken"></param>
        public OpenAPIListVersionData(
            bool? hasMore,
            global::System.Collections.Generic.IList<global::G.OpenAPIVersionMetaInfo>? items,
            string? nextPageToken)
        {
            this.HasMore = hasMore;
            this.Items = items;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIListVersionData" /> class.
        /// </summary>
        public OpenAPIListVersionData()
        {
        }
    }
}