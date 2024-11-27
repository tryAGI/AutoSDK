//HintName: G.Models.Validate2FactorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Validate2FactorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionKey", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ConnectionKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encryptedAuthToken", Required = global::Newtonsoft.Json.Required.Always)]
        public string EncryptedAuthToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Validate2FactorRequest" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="connectionKey"></param>
        /// <param name="encryptedAuthToken"></param>
        public Validate2FactorRequest(
            string username,
            global::System.Guid connectionKey,
            string encryptedAuthToken)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.ConnectionKey = connectionKey;
            this.EncryptedAuthToken = encryptedAuthToken ?? throw new global::System.ArgumentNullException(nameof(encryptedAuthToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Validate2FactorRequest" /> class.
        /// </summary>
        public Validate2FactorRequest()
        {
        }
    }
}