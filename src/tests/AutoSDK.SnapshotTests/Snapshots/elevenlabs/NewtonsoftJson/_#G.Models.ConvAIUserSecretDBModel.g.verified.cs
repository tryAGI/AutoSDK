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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encrypted_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string EncryptedValue { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nonce", Required = global::Newtonsoft.Json.Required.Always)]
        public string Nonce { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIUserSecretDBModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="encryptedValue"></param>
        /// <param name="nonce"></param>
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