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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The format of the public key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpkiPemPublicKeyConfigFormatJsonConverter))]
        public global::G.SpkiPemPublicKeyConfigFormat Format { get; set; }

        /// <summary>
        /// The PEM-encoded public key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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