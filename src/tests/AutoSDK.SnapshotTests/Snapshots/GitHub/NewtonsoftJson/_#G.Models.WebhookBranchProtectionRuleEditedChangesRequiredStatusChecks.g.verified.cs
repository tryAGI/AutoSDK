//HintName: G.Models.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> From { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks" /> class.
        /// </summary>
        /// <param name="from"></param>
        public WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks(
            global::System.Collections.Generic.IList<string> from)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks" /> class.
        /// </summary>
        public WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks()
        {
        }
    }
}