//HintName: G.Models.WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync
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
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync" /> class.
        /// </summary>
        /// <param name="from"></param>
        public WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync(
            bool? from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync" /> class.
        /// </summary>
        public WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync()
        {
        }
    }
}