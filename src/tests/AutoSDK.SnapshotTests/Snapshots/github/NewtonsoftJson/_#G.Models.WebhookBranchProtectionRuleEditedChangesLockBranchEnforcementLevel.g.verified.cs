//HintName: G.Models.WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom From { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel" /> class.
        /// </summary>
        /// <param name="from"></param>
        public WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel(
            global::G.WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevelFrom from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel" /> class.
        /// </summary>
        public WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel()
        {
        }
    }
}