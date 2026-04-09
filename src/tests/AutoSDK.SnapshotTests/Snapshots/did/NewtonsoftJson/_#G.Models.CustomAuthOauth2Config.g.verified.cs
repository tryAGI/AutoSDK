//HintName: G.Models.CustomAuthOauth2Config.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomAuthOauth2Config
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CustomAuthOauth2ConfigTypeJsonConverter))]
        public global::G.CustomAuthOauth2ConfigType Type { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientSecret { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TokenUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAuthOauth2Config" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="tokenUrl"></param>
        /// <param name="type"></param>
        /// <param name="streaming"></param>
        /// <param name="maxMessages"></param>
        /// <param name="headers"></param>
        /// <param name="supportsSentiment"></param>
        public CustomAuthOauth2Config(
            string url,
            string clientId,
            string clientSecret,
            string tokenUrl,
            global::G.CustomAuthOauth2ConfigType type,
            bool? streaming,
            double? maxMessages,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            bool? supportsSentiment)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Streaming = streaming;
            this.MaxMessages = maxMessages;
            this.Headers = headers;
            this.SupportsSentiment = supportsSentiment;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.TokenUrl = tokenUrl ?? throw new global::System.ArgumentNullException(nameof(tokenUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAuthOauth2Config" /> class.
        /// </summary>
        public CustomAuthOauth2Config()
        {
        }
    }
}