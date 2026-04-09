//HintName: G.Models.Source.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Source
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SourceTypeJsonConverter))]
        public global::G.SourceType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="filename"></param>
        /// <param name="contentType"></param>
        /// <param name="text"></param>
        public Source(
            global::G.SourceType? type,
            string? url,
            string? filename,
            string? contentType,
            string? text)
        {
            this.Type = type;
            this.Url = url;
            this.Filename = filename;
            this.ContentType = contentType;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        public Source()
        {
        }
    }
}