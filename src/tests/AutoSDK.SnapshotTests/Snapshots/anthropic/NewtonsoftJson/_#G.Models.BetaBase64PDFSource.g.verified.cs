//HintName: G.Models.BetaBase64PDFSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaBase64PDFSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaBase64PDFSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_type")]
        public global::G.BetaBase64PDFSourceMediaType MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBase64PDFSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="mediaType"></param>
        /// <param name="data"></param>
        public BetaBase64PDFSource(
            byte[] data,
            global::G.BetaBase64PDFSourceType type,
            global::G.BetaBase64PDFSourceMediaType mediaType)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
            this.MediaType = mediaType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBase64PDFSource" /> class.
        /// </summary>
        public BetaBase64PDFSource()
        {
        }
    }
}