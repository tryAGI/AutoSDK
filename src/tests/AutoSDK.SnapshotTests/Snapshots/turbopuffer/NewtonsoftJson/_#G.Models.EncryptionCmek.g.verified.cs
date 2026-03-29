//HintName: G.Models.EncryptionCmek.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EncryptionCmek
    {
        /// <summary>
        /// The identifier of the CMEK key to use for encryption. For GCP, the fully-qualified resource name of the key. For AWS, the ARN of the key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionCmek" /> class.
        /// </summary>
        /// <param name="keyName">
        /// The identifier of the CMEK key to use for encryption. For GCP, the fully-qualified resource name of the key. For AWS, the ARN of the key.
        /// </param>
        public EncryptionCmek(
            string keyName)
        {
            this.KeyName = keyName ?? throw new global::System.ArgumentNullException(nameof(keyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionCmek" /> class.
        /// </summary>
        public EncryptionCmek()
        {
        }
    }
}