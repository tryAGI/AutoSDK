//HintName: G.Models.ValidateUser2Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidateUser2Request
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rsaEncryptedPass", Required = global::Newtonsoft.Json.Required.Always)]
        public string RsaEncryptedPass { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionKey", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ConnectionKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateUser2Request" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="rsaEncryptedPass"></param>
        /// <param name="connectionKey"></param>
        public ValidateUser2Request(
            string username,
            string rsaEncryptedPass,
            global::System.Guid connectionKey)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.RsaEncryptedPass = rsaEncryptedPass ?? throw new global::System.ArgumentNullException(nameof(rsaEncryptedPass));
            this.ConnectionKey = connectionKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateUser2Request" /> class.
        /// </summary>
        public ValidateUser2Request()
        {
        }
    }
}