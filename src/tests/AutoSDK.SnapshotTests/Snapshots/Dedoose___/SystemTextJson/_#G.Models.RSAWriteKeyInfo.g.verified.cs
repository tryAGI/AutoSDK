//HintName: G.Models.RSAWriteKeyInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RSAWriteKeyInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modulus")]
        public string? Modulus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exponent")]
        public string? Exponent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RSAWriteKeyInfo" /> class.
        /// </summary>
        /// <param name="modulus"></param>
        /// <param name="exponent"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RSAWriteKeyInfo(
            string? modulus,
            string? exponent)
        {
            this.Modulus = modulus;
            this.Exponent = exponent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RSAWriteKeyInfo" /> class.
        /// </summary>
        public RSAWriteKeyInfo()
        {
        }
    }
}