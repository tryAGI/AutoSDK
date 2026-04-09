//HintName: G.Models.LLMConfigCreateDtoVariant2CustomBasic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMConfigCreateDtoVariant2CustomBasic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMConfigCreateDtoVariant2CustomBasicTypeJsonConverter))]
        public global::G.LLMConfigCreateDtoVariant2CustomBasicType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_messages")]
        public double? MaxMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_sentiment")]
        public bool? SupportsSentiment { get; set; }

        /// <summary>
        /// External API_KEY for D-ID to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The version of the API to use (Optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMConfigCreateDtoVariant2CustomBasic" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="key">
        /// External API_KEY for D-ID to use
        /// </param>
        /// <param name="type"></param>
        /// <param name="streaming"></param>
        /// <param name="maxMessages"></param>
        /// <param name="headers"></param>
        /// <param name="supportsSentiment"></param>
        /// <param name="version">
        /// The version of the API to use (Optional)
        /// </param>
        public LLMConfigCreateDtoVariant2CustomBasic(
            string url,
            string key,
            global::G.LLMConfigCreateDtoVariant2CustomBasicType type,
            bool? streaming,
            double? maxMessages,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            bool? supportsSentiment,
            string? version)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Streaming = streaming;
            this.MaxMessages = maxMessages;
            this.Headers = headers;
            this.SupportsSentiment = supportsSentiment;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMConfigCreateDtoVariant2CustomBasic" /> class.
        /// </summary>
        public LLMConfigCreateDtoVariant2CustomBasic()
        {
        }
    }
}