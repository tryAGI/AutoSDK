//HintName: G.Models.GetDeepResearchStatusResponseDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeepResearchStatusResponseDataSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeepResearchStatusResponseDataSource" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="favicon"></param>
        public GetDeepResearchStatusResponseDataSource(
            string? url,
            string? title,
            string? description,
            string? favicon)
        {
            this.Url = url;
            this.Title = title;
            this.Description = description;
            this.Favicon = favicon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeepResearchStatusResponseDataSource" /> class.
        /// </summary>
        public GetDeepResearchStatusResponseDataSource()
        {
        }
    }
}