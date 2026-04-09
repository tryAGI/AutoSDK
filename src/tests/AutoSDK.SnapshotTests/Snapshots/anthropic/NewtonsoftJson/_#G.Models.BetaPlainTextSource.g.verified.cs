//HintName: G.Models.BetaPlainTextSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaPlainTextSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BetaPlainTextSourceTypeJsonConverter))]
        public global::G.BetaPlainTextSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BetaPlainTextSourceMediaTypeJsonConverter))]
        public global::G.BetaPlainTextSourceMediaType MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPlainTextSource" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="mediaType"></param>
        public BetaPlainTextSource(
            string data,
            global::G.BetaPlainTextSourceType type,
            global::G.BetaPlainTextSourceMediaType mediaType)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPlainTextSource" /> class.
        /// </summary>
        public BetaPlainTextSource()
        {
        }
    }
}