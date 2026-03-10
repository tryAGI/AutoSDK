//HintName: G.Models.WebhooksMembership.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The membership between the user and the organization. Not present when the action is `member_invited`.
    /// </summary>
    public sealed partial class WebhooksMembership
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.WebhooksMembershipUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksMembership" /> class.
        /// </summary>
        /// <param name="organizationUrl"></param>
        /// <param name="role"></param>
        /// <param name="state"></param>
        /// <param name="url"></param>
        /// <param name="user"></param>
        public WebhooksMembership(
            string organizationUrl,
            string role,
            string state,
            string url,
            global::G.WebhooksMembershipUser? user)
        {
            this.OrganizationUrl = organizationUrl ?? throw new global::System.ArgumentNullException(nameof(organizationUrl));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksMembership" /> class.
        /// </summary>
        public WebhooksMembership()
        {
        }
    }
}