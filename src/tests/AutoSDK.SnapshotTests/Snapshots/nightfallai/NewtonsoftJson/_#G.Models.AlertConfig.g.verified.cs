//HintName: G.Models.AlertConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slack")]
        public global::G.SlackAlert? Slack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public global::G.EmailAlert? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public global::G.WebhookAlert? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertConfig" /> class.
        /// </summary>
        /// <param name="slack"></param>
        /// <param name="email"></param>
        /// <param name="url"></param>
        public AlertConfig(
            global::G.SlackAlert? slack,
            global::G.EmailAlert? email,
            global::G.WebhookAlert? url)
        {
            this.Slack = slack;
            this.Email = email;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertConfig" /> class.
        /// </summary>
        public AlertConfig()
        {
        }
    }
}