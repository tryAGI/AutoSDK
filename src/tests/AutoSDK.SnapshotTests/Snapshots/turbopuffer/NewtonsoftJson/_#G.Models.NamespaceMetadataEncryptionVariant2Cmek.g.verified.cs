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
        [global::Newtonsoft.Json.JsonProperty("key_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataEncryptionVariant2Cmek" /> class.
        /// </summary>
        /// <param name="keyName">
        /// The name of the CMEK key in use.
        /// </param>
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