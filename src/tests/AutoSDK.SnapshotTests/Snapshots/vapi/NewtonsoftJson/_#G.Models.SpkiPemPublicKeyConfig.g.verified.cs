//HintName: G.Models.SpkiPemPublicKeyConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpkiPemPublicKeyConfig
    {
        /// <summary>
        /// Optional name of the key for identification purposes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The format of the public key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.SpkiPemPublicKeyConfigFormat Format { get; set; }

        /// <summary>
        /// The PEM-encoded public key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pem", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pem { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpkiPemPublicKeyConfig" /> class.
        /// </summary>
        /// <param name="pem">
        /// The PEM-encoded public key.
        /// </param>
        /// <param name="name">
        /// Optional name of the key for identification purposes.
        /// </param>
        /// <param name="format">
        /// The format of the public key.
        /// </param>
        public SpkiPemPublicKeyConfig(
            string pem,
            string? name,
            global::G.SpkiPemPublicKeyConfigFormat format)
        {
            this.Name = name;
            this.Format = format;
            this.Pem = pem ?? throw new global::System.ArgumentNullException(nameof(pem));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpkiPemPublicKeyConfig" /> class.
        /// </summary>
        public SpkiPemPublicKeyConfig()
        {
        }
    }
}