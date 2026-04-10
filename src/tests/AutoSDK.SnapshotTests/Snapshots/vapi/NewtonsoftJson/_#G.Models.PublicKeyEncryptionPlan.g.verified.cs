//HintName: G.Models.PublicKeyEncryptionPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicKeyEncryptionPlan
    {
        /// <summary>
        /// The type of encryption plan.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PublicKeyEncryptionPlanTypeJsonConverter))]
        public global::G.PublicKeyEncryptionPlanType Type { get; set; }

        /// <summary>
        /// The encryption algorithm to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("algorithm")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PublicKeyEncryptionPlanAlgorithmJsonConverter))]
        public global::G.PublicKeyEncryptionPlanAlgorithm Algorithm { get; set; }

        /// <summary>
        /// The public key configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicKey", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpkiPemPublicKeyConfig PublicKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyEncryptionPlan" /> class.
        /// </summary>
        /// <param name="publicKey">
        /// The public key configuration.
        /// </param>
        /// <param name="type">
        /// The type of encryption plan.
        /// </param>
        /// <param name="algorithm">
        /// The encryption algorithm to use.
        /// </param>
        public PublicKeyEncryptionPlan(
            global::G.SpkiPemPublicKeyConfig publicKey,
            global::G.PublicKeyEncryptionPlanType type,
            global::G.PublicKeyEncryptionPlanAlgorithm algorithm)
        {
            this.Type = type;
            this.Algorithm = algorithm;
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyEncryptionPlan" /> class.
        /// </summary>
        public PublicKeyEncryptionPlan()
        {
        }
    }
}