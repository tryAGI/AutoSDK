//HintName: G.Models.ChatResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chat completion response
    /// </summary>
    public sealed partial class ChatResult
    {
        /// <summary>
        /// Unique completion identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// List of completion choices
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatChoice> Choices { get; set; } = default!;

        /// <summary>
        /// Unix timestamp of creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public double Created { get; set; } = default!;

        /// <summary>
        /// Model used for completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatResultObjectJsonConverter))]
        public global::G.ChatResultObject Object { get; set; }

        /// <summary>
        /// System fingerprint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// The service tier used by the upstream provider for this request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// Token usage statistics
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.ChatUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResult" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique completion identifier
        /// </param>
        /// <param name="choices">
        /// List of completion choices
        /// </param>
        /// <param name="created">
        /// Unix timestamp of creation
        /// </param>
        /// <param name="model">
        /// Model used for completion
        /// </param>
        /// <param name="object"></param>
        /// <param name="systemFingerprint">
        /// System fingerprint
        /// </param>
        /// <param name="serviceTier">
        /// The service tier used by the upstream provider for this request
        /// </param>
        /// <param name="usage">
        /// Token usage statistics
        /// </param>
        public ChatResult(
            string id,
            global::System.Collections.Generic.IList<global::G.ChatChoice> choices,
            double created,
            string model,
            global::G.ChatResultObject @object,
            string? systemFingerprint,
            string? serviceTier,
            global::G.ChatUsage? usage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.SystemFingerprint = systemFingerprint;
            this.ServiceTier = serviceTier;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatResult" /> class.
        /// </summary>
        public ChatResult()
        {
        }
    }
}