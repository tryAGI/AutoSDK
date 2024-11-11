//HintName: G.Models.WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public bool? From { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly" /> class.
        /// </summary>
        /// <param name="from"></param>
        public WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly(
            bool? from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly" /> class.
        /// </summary>
        public WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly()
        {
        }
    }
}