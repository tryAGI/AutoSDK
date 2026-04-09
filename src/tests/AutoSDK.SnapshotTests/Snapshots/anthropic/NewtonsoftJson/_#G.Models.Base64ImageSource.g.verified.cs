//HintName: G.Models.Base64ImageSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Base64ImageSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.Base64ImageSourceTypeJsonConverter))]
        public global::G.Base64ImageSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.Base64ImageSourceMediaTypeJsonConverter))]
        public global::G.Base64ImageSourceMediaType MediaType { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="Base64ImageSource" /> class.
        /// </summary>
        /// <param name="mediaType"></param>
        /// <param name="data"></param>
        /// <param name="type"></param>
        public Base64ImageSource(
            global::G.Base64ImageSourceMediaType mediaType,
            byte[] data,
            global::G.Base64ImageSourceType type)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Base64ImageSource" /> class.
        /// </summary>
        public Base64ImageSource()
        {
        }
    }
}