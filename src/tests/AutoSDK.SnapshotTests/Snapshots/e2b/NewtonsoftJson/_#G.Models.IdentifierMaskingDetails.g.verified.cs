//HintName: G.Models.IdentifierMaskingDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdentifierMaskingDetails
    {
        /// <summary>
        /// Prefix that identifies the token or key type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prefix { get; set; } = default!;

        /// <summary>
        /// Length of the token or key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueLength", Required = global::Newtonsoft.Json.Required.Always)]
        public int ValueLength { get; set; } = default!;

        /// <summary>
        /// Prefix used in masked version of the token or key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskedValuePrefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string MaskedValuePrefix { get; set; } = default!;

        /// <summary>
        /// Suffix used in masked version of the token or key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maskedValueSuffix", Required = global::Newtonsoft.Json.Required.Always)]
        public string MaskedValueSuffix { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentifierMaskingDetails" /> class.
        /// </summary>
        /// <param name="prefix">
        /// Prefix that identifies the token or key type
        /// </param>
        /// <param name="valueLength">
        /// Length of the token or key
        /// </param>
        /// <param name="maskedValuePrefix">
        /// Prefix used in masked version of the token or key
        /// </param>
        /// <param name="maskedValueSuffix">
        /// Suffix used in masked version of the token or key
        /// </param>
        public IdentifierMaskingDetails(
            string prefix,
            int valueLength,
            string maskedValuePrefix,
            string maskedValueSuffix)
        {
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
            this.ValueLength = valueLength;
            this.MaskedValuePrefix = maskedValuePrefix ?? throw new global::System.ArgumentNullException(nameof(maskedValuePrefix));
            this.MaskedValueSuffix = maskedValueSuffix ?? throw new global::System.ArgumentNullException(nameof(maskedValueSuffix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentifierMaskingDetails" /> class.
        /// </summary>
        public IdentifierMaskingDetails()
        {
        }
    }
}