//HintName: G.Models.SIPTrunkCredentials.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SIPTrunkCredentials
    {
        /// <summary>
        /// SIP trunk username
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// SIP trunk password
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password", Required = global::Newtonsoft.Json.Required.Always)]
        public string Password { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkCredentials" /> class.
        /// </summary>
        /// <param name="username">
        /// SIP trunk username
        /// </param>
        /// <param name="password">
        /// SIP trunk password
        /// </param>
        public SIPTrunkCredentials(
            string username,
            string password)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkCredentials" /> class.
        /// </summary>
        public SIPTrunkCredentials()
        {
        }
    }
}