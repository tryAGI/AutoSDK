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
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// Length of the token or key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueLength")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ValueLength { get; set; }

        /// <summary>
        /// Prefix used in masked version of the token or key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskedValuePrefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MaskedValuePrefix { get; set; }

        /// <summary>
        /// Suffix used in masked version of the token or key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskedValueSuffix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MaskedValueSuffix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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