//HintName: G.Models.ChunkStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caption_type")]
        public int? CaptionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_type")]
        public int? ChunkType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_extra_spaces")]
        public bool? RemoveExtraSpaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_urls_emails")]
        public bool? RemoveUrlsEmails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("separator")]
        public string? Separator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkStrategy" /> class.
        /// </summary>
        /// <param name="captionType"></param>
        /// <param name="chunkType"></param>
        /// <param name="maxTokens"></param>
        /// <param name="removeExtraSpaces"></param>
        /// <param name="removeUrlsEmails"></param>
        /// <param name="separator"></param>
        public ChunkStrategy(
            int? captionType,
            int? chunkType,
            int? maxTokens,
            bool? removeExtraSpaces,
            bool? removeUrlsEmails,
            string? separator)
        {
            this.CaptionType = captionType;
            this.ChunkType = chunkType;
            this.MaxTokens = maxTokens;
            this.RemoveExtraSpaces = removeExtraSpaces;
            this.RemoveUrlsEmails = removeUrlsEmails;
            this.Separator = separator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkStrategy" /> class.
        /// </summary>
        public ChunkStrategy()
        {
        }
    }
}