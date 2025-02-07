//HintName: G.Models.WebhookTeamEditedChangesNotificationSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookTeamEditedChangesNotificationSetting
    {
        /// <summary>
        /// The previous version of the team's notification setting if the action was `edited`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChangesNotificationSetting" /> class.
        /// </summary>
        /// <param name="from">
        /// The previous version of the team's notification setting if the action was `edited`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookTeamEditedChangesNotificationSetting(
            string from)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChangesNotificationSetting" /> class.
        /// </summary>
        public WebhookTeamEditedChangesNotificationSetting()
        {
        }
    }
}