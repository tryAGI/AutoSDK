//HintName: G.Models.ConvAIUserSecretDBModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User-specific secret model that are not shared with other users in a workspace.
    /// </summary>
    public sealed partial class ConvAIUserSecretDBModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nonce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nonce { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIUserSecretDBModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="encryptedValue"></param>
        /// <param name="nonce"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvAIUserSecretDBModel(
            string id,
            string name,
            string encryptedValue,
            string nonce)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EncryptedValue = encryptedValue ?? throw new global::System.ArgumentNullException(nameof(encryptedValue));
            this.Nonce = nonce ?? throw new global::System.ArgumentNullException(nameof(nonce));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIUserSecretDBModel" /> class.
        /// </summary>
        public ConvAIUserSecretDBModel()
        {
        }
    }
}