//HintName: G.Models.AgentCreateDtoLlmVariant2CustomOAuth2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCreateDtoLlmVariant2CustomOAuth2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentCreateDtoLlmVariant2CustomOAuth2TypeJsonConverter))]
        public global::G.AgentCreateDtoLlmVariant2CustomOAuth2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_messages")]
        public double? MaxMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_sentiment")]
        public bool? SupportsSentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoLlmVariant2CustomOAuth2" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCreateDtoLlmVariant2CustomOAuth2(
            string url,
            string clientId,
            string clientSecret,
            string tokenUrl,
            global::G.AgentCreateDtoLlmVariant2CustomOAuth2Type type,
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
        /// Initializes a new instance of the <see cref="AgentCreateDtoLlmVariant2CustomOAuth2" /> class.
        /// </summary>
        public AgentCreateDtoLlmVariant2CustomOAuth2()
        {
        }
    }
}