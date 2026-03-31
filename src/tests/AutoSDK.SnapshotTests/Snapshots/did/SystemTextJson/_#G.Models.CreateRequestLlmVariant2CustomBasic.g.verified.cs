//HintName: G.Models.CreateRequestLlmVariant2CustomBasic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequestLlmVariant2CustomBasic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateRequestLlmVariant2CustomBasicTypeJsonConverter))]
        public global::G.CreateRequestLlmVariant2CustomBasicType Type { get; set; }

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
        /// External API_KEY for D-ID to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The version of the API to use (Optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequestLlmVariant2CustomBasic" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequestLlmVariant2CustomBasic(
            string url,
            string key,
            global::G.CreateRequestLlmVariant2CustomBasicType type,
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
        /// Initializes a new instance of the <see cref="CreateRequestLlmVariant2CustomBasic" /> class.
        /// </summary>
        public CreateRequestLlmVariant2CustomBasic()
        {
        }
    }
}