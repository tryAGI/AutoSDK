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
        [global::Newtonsoft.Json.JsonProperty("modulus")]
        public string? Modulus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exponent")]
        public string? Exponent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RSAWriteKeyInfo" /> class.
        /// </summary>
        /// <param name="modulus"></param>
        /// <param name="exponent"></param>
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