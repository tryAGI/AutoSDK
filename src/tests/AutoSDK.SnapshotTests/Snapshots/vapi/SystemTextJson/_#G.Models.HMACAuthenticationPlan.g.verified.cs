//HintName: G.Models.HMACAuthenticationPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HMACAuthenticationPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HMACAuthenticationPlanTypeJsonConverter))]
        public global::G.HMACAuthenticationPlanType Type { get; set; }

        /// <summary>
        /// This is the HMAC secret key used to sign requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretKey { get; set; }

        /// <summary>
        /// This is the HMAC algorithm to use for signing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HMACAuthenticationPlanAlgorithmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HMACAuthenticationPlanAlgorithm Algorithm { get; set; }

        /// <summary>
        /// This is the header name where the signature will be sent. Defaults to 'x-signature'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatureHeader")]
        public string? SignatureHeader { get; set; }

        /// <summary>
        /// This is the header name where the timestamp will be sent. Defaults to 'x-timestamp'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestampHeader")]
        public string? TimestampHeader { get; set; }

        /// <summary>
        /// This is the prefix for the signature. For example, 'sha256=' for GitHub-style signatures.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signaturePrefix")]
        public string? SignaturePrefix { get; set; }

        /// <summary>
        /// Whether to include a timestamp in the signature payload. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeTimestamp")]
        public bool? IncludeTimestamp { get; set; }

        /// <summary>
        /// Custom payload format. Use {body} for request body, {timestamp} for timestamp, {method} for HTTP method, {url} for URL, {svix-id} for unique message ID. Defaults to '{timestamp}.{body}'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloadFormat")]
        public string? PayloadFormat { get; set; }

        /// <summary>
        /// This is the header name where the unique message ID will be sent. Used for Svix-style webhooks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageIdHeader")]
        public string? MessageIdHeader { get; set; }

        /// <summary>
        /// The encoding format for the signature. Defaults to 'hex'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatureEncoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HMACAuthenticationPlanSignatureEncodingJsonConverter))]
        public global::G.HMACAuthenticationPlanSignatureEncoding? SignatureEncoding { get; set; }

        /// <summary>
        /// Whether the secret key is base64-encoded and should be decoded before use. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretIsBase64")]
        public bool? SecretIsBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HMACAuthenticationPlan" /> class.
        /// </summary>
        /// <param name="secretKey">
        /// This is the HMAC secret key used to sign requests.
        /// </param>
        /// <param name="algorithm">
        /// This is the HMAC algorithm to use for signing.
        /// </param>
        /// <param name="type"></param>
        /// <param name="signatureHeader">
        /// This is the header name where the signature will be sent. Defaults to 'x-signature'.
        /// </param>
        /// <param name="timestampHeader">
        /// This is the header name where the timestamp will be sent. Defaults to 'x-timestamp'.
        /// </param>
        /// <param name="signaturePrefix">
        /// This is the prefix for the signature. For example, 'sha256=' for GitHub-style signatures.
        /// </param>
        /// <param name="includeTimestamp">
        /// Whether to include a timestamp in the signature payload. Defaults to true.
        /// </param>
        /// <param name="payloadFormat">
        /// Custom payload format. Use {body} for request body, {timestamp} for timestamp, {method} for HTTP method, {url} for URL, {svix-id} for unique message ID. Defaults to '{timestamp}.{body}'.
        /// </param>
        /// <param name="messageIdHeader">
        /// This is the header name where the unique message ID will be sent. Used for Svix-style webhooks.
        /// </param>
        /// <param name="signatureEncoding">
        /// The encoding format for the signature. Defaults to 'hex'.
        /// </param>
        /// <param name="secretIsBase64">
        /// Whether the secret key is base64-encoded and should be decoded before use. Defaults to false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HMACAuthenticationPlan(
            string secretKey,
            global::G.HMACAuthenticationPlanAlgorithm algorithm,
            global::G.HMACAuthenticationPlanType type,
            string? signatureHeader,
            string? timestampHeader,
            string? signaturePrefix,
            bool? includeTimestamp,
            string? payloadFormat,
            string? messageIdHeader,
            global::G.HMACAuthenticationPlanSignatureEncoding? signatureEncoding,
            bool? secretIsBase64)
        {
            this.Type = type;
            this.SecretKey = secretKey ?? throw new global::System.ArgumentNullException(nameof(secretKey));
            this.Algorithm = algorithm;
            this.SignatureHeader = signatureHeader;
            this.TimestampHeader = timestampHeader;
            this.SignaturePrefix = signaturePrefix;
            this.IncludeTimestamp = includeTimestamp;
            this.PayloadFormat = payloadFormat;
            this.MessageIdHeader = messageIdHeader;
            this.SignatureEncoding = signatureEncoding;
            this.SecretIsBase64 = secretIsBase64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HMACAuthenticationPlan" /> class.
        /// </summary>
        public HMACAuthenticationPlan()
        {
        }
    }
}