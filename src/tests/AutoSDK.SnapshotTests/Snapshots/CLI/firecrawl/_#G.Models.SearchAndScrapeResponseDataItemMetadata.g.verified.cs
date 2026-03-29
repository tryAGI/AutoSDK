//HintName: G.Models.SearchAndScrapeResponseDataItemMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchAndScrapeResponseDataItemMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceURL")]
        public string? SourceURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeResponseDataItemMetadata" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="sourceURL"></param>
        /// <param name="statusCode"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchAndScrapeResponseDataItemMetadata(
            string? title,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? description,
            string? sourceURL,
            int? statusCode,
            string? error)
        {
            this.Title = title;
            this.Description = description;
            this.SourceURL = sourceURL;
            this.StatusCode = statusCode;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeResponseDataItemMetadata" /> class.
        /// </summary>
        public SearchAndScrapeResponseDataItemMetadata()
        {
        }
    }
}