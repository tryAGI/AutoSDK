//HintName: G.Models.SipAuthentication.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SipAuthentication
    {
        /// <summary>
        /// This will be expected in the `realm` field of the `authorization` header of the SIP INVITE. Defaults to sip.vapi.ai.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("realm")]
        public string? Realm { get; set; }

        /// <summary>
        /// This will be expected in the `username` field of the `authorization` header of the SIP INVITE.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// This will be expected to generate the `response` field of the `authorization` header of the SIP INVITE, through digest authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password", Required = global::Newtonsoft.Json.Required.Always)]
        public string Password { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SipAuthentication" /> class.
        /// </summary>
        /// <param name="username">
        /// This will be expected in the `username` field of the `authorization` header of the SIP INVITE.
        /// </param>
        /// <param name="password">
        /// This will be expected to generate the `response` field of the `authorization` header of the SIP INVITE, through digest authentication.
        /// </param>
        /// <param name="realm">
        /// This will be expected in the `realm` field of the `authorization` header of the SIP INVITE. Defaults to sip.vapi.ai.
        /// </param>
        public SipAuthentication(
            string username,
            string password,
            string? realm)
        {
            this.Realm = realm;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SipAuthentication" /> class.
        /// </summary>
        public SipAuthentication()
        {
        }
    }
}