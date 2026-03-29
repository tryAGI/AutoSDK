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
        [global::System.Text.Json.Serialization.JsonPropertyName("slack")]
        public global::G.SlackAlert? Slack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public global::G.EmailAlert? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public global::G.WebhookAlert? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertConfig" /> class.
        /// </summary>
        /// <param name="slack"></param>
        /// <param name="email"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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