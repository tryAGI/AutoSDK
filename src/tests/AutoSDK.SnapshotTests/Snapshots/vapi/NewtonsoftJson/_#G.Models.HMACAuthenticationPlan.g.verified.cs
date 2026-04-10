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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.HMACAuthenticationPlanTypeJsonConverter))]
        public global::G.HMACAuthenticationPlanType Type { get; set; }

        /// <summary>
        /// This is the HMAC secret key used to sign requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secretKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string SecretKey { get; set; } = default!;

        /// <summary>
        /// This is the HMAC algorithm to use for signing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("algorithm", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.HMACAuthenticationPlanAlgorithmJsonConverter))]
        public global::G.HMACAuthenticationPlanAlgorithm Algorithm { get; set; } = default!;

        /// <summary>
        /// This is the header name where the signature will be sent. Defaults to 'x-signature'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signatureHeader")]
        public string? SignatureHeader { get; set; }

        /// <summary>
        /// This is the header name where the timestamp will be sent. Defaults to 'x-timestamp'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestampHeader")]
        public string? TimestampHeader { get; set; }

        /// <summary>
        /// This is the prefix for the signature. For example, 'sha256=' for GitHub-style signatures.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signaturePrefix")]
        public string? SignaturePrefix { get; set; }

        /// <summary>
        /// Whether to include a timestamp in the signature payload. Defaults to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeTimestamp")]
        public bool? IncludeTimestamp { get; set; }

        /// <summary>
        /// Custom payload format. Use {body} for request body, {timestamp} for timestamp, {method} for HTTP method, {url} for URL, {svix-id} for unique message ID. Defaults to '{timestamp}.{body}'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payloadFormat")]
        public string? PayloadFormat { get; set; }

        /// <summary>
        /// This is the header name where the unique message ID will be sent. Used for Svix-style webhooks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messageIdHeader")]
        public string? MessageIdHeader { get; set; }

        /// <summary>
        /// The encoding format for the signature. Defaults to 'hex'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signatureEncoding")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.HMACAuthenticationPlanSignatureEncodingJsonConverter))]
        public global::G.HMACAuthenticationPlanSignatureEncoding? SignatureEncoding { get; set; }

        /// <summary>
        /// Whether the secret key is base64-encoded and should be decoded before use. Defaults to false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secretIsBase64")]
        public bool? SecretIsBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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