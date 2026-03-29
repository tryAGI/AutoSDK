//HintName: G.Models.WebAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebAnnotation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"url_citation"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "url_citation";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndIndex { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cited_text")]
        public string? CitedText { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encrypted_index")]
        public string? EncryptedIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebAnnotation" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="url"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <param name="citedText">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="encryptedIndex">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type"></param>
        public WebAnnotation(
            string title,
            string url,
            int startIndex,
            int endIndex,
            string? citedText,
            string? encryptedIndex,
            string type = "url_citation")
        {
            this.Type = type;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.CitedText = citedText;
            this.EncryptedIndex = encryptedIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebAnnotation" /> class.
        /// </summary>
        public WebAnnotation()
        {
        }
    }
}