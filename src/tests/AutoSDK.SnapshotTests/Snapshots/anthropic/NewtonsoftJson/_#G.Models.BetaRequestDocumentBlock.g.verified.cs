//HintName: G.Models.BetaRequestDocumentBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestDocumentBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaRequestDocumentBlockType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Source Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citations")]
        public global::G.BetaRequestCitationsConfig? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestDocumentBlock" /> class.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
        /// <param name="source"></param>
        /// <param name="title"></param>
        /// <param name="context"></param>
        /// <param name="citations"></param>
        public BetaRequestDocumentBlock(
            global::G.Source source,
            global::G.BetaCacheControlEphemeral? cacheControl,
            global::G.BetaRequestDocumentBlockType type,
            string? title,
            string? context,
            global::G.BetaRequestCitationsConfig? citations)
        {
            this.Source = source;
            this.CacheControl = cacheControl;
            this.Type = type;
            this.Title = title;
            this.Context = context;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestDocumentBlock" /> class.
        /// </summary>
        public BetaRequestDocumentBlock()
        {
        }
    }
}