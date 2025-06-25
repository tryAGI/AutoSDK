﻿//HintName: G.Models.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFromJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel" /> class.
        /// </summary>
        /// <param name="from"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel(
            global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel" /> class.
        /// </summary>
        public WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel()
        {
        }
    }
}