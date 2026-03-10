//HintName: G.Models.SIPTrunkCredentialsRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SIPTrunkCredentialsRequestModel
    {
        /// <summary>
        /// SIP trunk username
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// SIP trunk password - if not specified, then remain unchanged
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkCredentialsRequestModel" /> class.
        /// </summary>
        /// <param name="username">
        /// SIP trunk username
        /// </param>
        /// <param name="password">
        /// SIP trunk password - if not specified, then remain unchanged
        /// </param>
        public SIPTrunkCredentialsRequestModel(
            string username,
            string? password)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPTrunkCredentialsRequestModel" /> class.
        /// </summary>
        public SIPTrunkCredentialsRequestModel()
        {
        }
    }
}