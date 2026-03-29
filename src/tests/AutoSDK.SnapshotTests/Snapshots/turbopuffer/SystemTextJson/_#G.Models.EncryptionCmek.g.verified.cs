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
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionCmek" /> class.
        /// </summary>
        /// <param name="keyName">
        /// The identifier of the CMEK key to use for encryption. For GCP, the fully-qualified resource name of the key. For AWS, the ARN of the key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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