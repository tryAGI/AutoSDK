//HintName: G.Models.NamespaceMetadataEncryptionVariant2Cmek.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NamespaceMetadataEncryptionVariant2Cmek
    {
        /// <summary>
        /// The name of the CMEK key in use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataEncryptionVariant2Cmek" /> class.
        /// </summary>
        /// <param name="keyName">
        /// The name of the CMEK key in use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamespaceMetadataEncryptionVariant2Cmek(
            string keyName)
        {
            this.KeyName = keyName ?? throw new global::System.ArgumentNullException(nameof(keyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataEncryptionVariant2Cmek" /> class.
        /// </summary>
        public NamespaceMetadataEncryptionVariant2Cmek()
        {
        }
    }
}