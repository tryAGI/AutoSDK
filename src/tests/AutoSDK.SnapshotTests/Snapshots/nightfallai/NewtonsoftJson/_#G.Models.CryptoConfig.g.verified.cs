//HintName: G.Models.CryptoConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CryptoConfig
    {
        /// <summary>
        /// RSA public key in PEM format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicKey")]
        public string? PublicKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoConfig" /> class.
        /// </summary>
        /// <param name="publicKey">
        /// RSA public key in PEM format
        /// </param>
        public CryptoConfig(
            string? publicKey)
        {
            this.PublicKey = publicKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CryptoConfig" /> class.
        /// </summary>
        public CryptoConfig()
        {
        }
    }
}