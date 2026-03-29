//HintName: G.Models.NamespaceMetadataEncryptionVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates that the namespace is encrypted with a customer-managed encryption key (CMEK).
    /// </summary>
    public sealed partial class NamespaceMetadataEncryptionVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmek")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NamespaceMetadataEncryptionVariant2Cmek Cmek { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataEncryptionVariant2" /> class.
        /// </summary>
        /// <param name="cmek"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamespaceMetadataEncryptionVariant2(
            global::G.NamespaceMetadataEncryptionVariant2Cmek cmek)
        {
            this.Cmek = cmek ?? throw new global::System.ArgumentNullException(nameof(cmek));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataEncryptionVariant2" /> class.
        /// </summary>
        public NamespaceMetadataEncryptionVariant2()
        {
        }
    }
}