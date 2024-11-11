//HintName: G.Models.DependabotPublicKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The public key used for setting Dependabot Secrets.
    /// </summary>
    public sealed partial class DependabotPublicKey
    {
        /// <summary>
        /// The identifier for the key.<br/>
        /// Example: 1234567
        /// </summary>
        /// <example>1234567</example>
        [global::Newtonsoft.Json.JsonProperty("key_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string KeyId { get; set; } = default!;

        /// <summary>
        /// The Base64 encoded public key.<br/>
        /// Example: hBT5WZEj8ZoOv6TYJsfWq7MxTEQopZO5/IT3ZCVQPzs=
        /// </summary>
        /// <example>hBT5WZEj8ZoOv6TYJsfWq7MxTEQopZO5/IT3ZCVQPzs=</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotPublicKey" /> class.
        /// </summary>
        /// <param name="keyId">
        /// The identifier for the key.<br/>
        /// Example: 1234567
        /// </param>
        /// <param name="key">
        /// The Base64 encoded public key.<br/>
        /// Example: hBT5WZEj8ZoOv6TYJsfWq7MxTEQopZO5/IT3ZCVQPzs=
        /// </param>
        public DependabotPublicKey(
            string keyId,
            string key)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotPublicKey" /> class.
        /// </summary>
        public DependabotPublicKey()
        {
        }
    }
}