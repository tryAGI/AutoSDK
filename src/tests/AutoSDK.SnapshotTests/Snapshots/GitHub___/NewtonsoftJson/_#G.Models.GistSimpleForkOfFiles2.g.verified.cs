//HintName: G.Models.GistSimpleForkOfFiles2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistSimpleForkOfFiles2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_url")]
        public string? RawUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistSimpleForkOfFiles2" /> class.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="type"></param>
        /// <param name="language"></param>
        /// <param name="rawUrl"></param>
        /// <param name="size"></param>
        public GistSimpleForkOfFiles2(
            string? filename,
            string? type,
            string? language,
            string? rawUrl,
            int? size)
        {
            this.Filename = filename;
            this.Type = type;
            this.Language = language;
            this.RawUrl = rawUrl;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistSimpleForkOfFiles2" /> class.
        /// </summary>
        public GistSimpleForkOfFiles2()
        {
        }
    }
}