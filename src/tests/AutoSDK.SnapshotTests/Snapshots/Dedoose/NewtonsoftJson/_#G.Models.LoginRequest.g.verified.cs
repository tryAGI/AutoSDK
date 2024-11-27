//HintName: G.Models.LoginRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoginRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rsaEncryptedPassword", Required = global::Newtonsoft.Json.Required.Always)]
        public string RsaEncryptedPassword { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginRequest" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="rsaEncryptedPassword"></param>
        public LoginRequest(
            string username,
            string rsaEncryptedPassword)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.RsaEncryptedPassword = rsaEncryptedPassword ?? throw new global::System.ArgumentNullException(nameof(rsaEncryptedPassword));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginRequest" /> class.
        /// </summary>
        public LoginRequest()
        {
        }
    }
}