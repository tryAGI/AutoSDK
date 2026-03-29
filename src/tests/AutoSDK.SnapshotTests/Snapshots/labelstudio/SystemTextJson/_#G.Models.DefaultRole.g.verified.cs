//HintName: G.Models.DefaultRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DefaultRole
    {
        /// <summary>
        /// Set to current time to restrict data sharing between annotators and reviewers in the label stream, review stream, and notifications (which will be disabled). In these settings, information about annotator and reviewer identity is suppressed in the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotator_reviewer_firewall_enabled_at")]
        public global::System.DateTime? AnnotatorReviewerFirewallEnabledAt { get; set; }

        /// <summary>
        /// Set to current time to enable custom scripts (Plugins) for this organization. Can only be enabled if no organization members are active members of any other organizations; otherwise an error will be raised. If this occurs, contact the LEAP team for assistance with enabling custom scripts (Plugins).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_scripts_enabled_at")]
        public global::System.DateTime? CustomScriptsEnabledAt { get; set; }

        /// <summary>
        /// Default membership role for invited users<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Role9e7EnumJsonConverter))]
        public global::G.Role9e7Enum? DefaultRole1 { get; set; }

        /// <summary>
        /// Email notification settings for this organization. Controls which email notifications users can receive. Structure: {"notifications_allowed": {"notification_type": bool}}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_notification_settings")]
        public object? EmailNotificationSettings { get; set; }

        /// <summary>
        /// List of objects: {"domain": "example.com"}. Used for CSP header on /embed routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_domains")]
        public object? EmbedDomains { get; set; }

        /// <summary>
        /// Embed settings for this organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_settings")]
        public object? EmbedSettings { get; set; }

        /// <summary>
        /// External ID to uniquely identify this organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_data_on_activity_logs")]
        public bool? ExtraDataOnActivityLogs { get; set; }

        /// <summary>
        /// Set to current time to disable the label stream navigation for this organization. This will prevent users from going back in the label stream to view previous labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_stream_navigation_disabled_at")]
        public global::System.DateTime? LabelStreamNavigationDisabledAt { get; set; }

        /// <summary>
        /// A unique integer value identifying this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Organization { get; set; }

        /// <summary>
        /// Set to current time to prevent creating or editing annotations in quick view.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only_quick_view_enabled_at")]
        public global::System.DateTime? ReadOnlyQuickViewEnabledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultRole" /> class.
        /// </summary>
        /// <param name="organization">
        /// A unique integer value identifying this organization.
        /// </param>
        /// <param name="annotatorReviewerFirewallEnabledAt">
        /// Set to current time to restrict data sharing between annotators and reviewers in the label stream, review stream, and notifications (which will be disabled). In these settings, information about annotator and reviewer identity is suppressed in the UI.
        /// </param>
        /// <param name="customScriptsEnabledAt">
        /// Set to current time to enable custom scripts (Plugins) for this organization. Can only be enabled if no organization members are active members of any other organizations; otherwise an error will be raised. If this occurs, contact the LEAP team for assistance with enabling custom scripts (Plugins).
        /// </param>
        /// <param name="defaultRole1">
        /// Default membership role for invited users<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="emailNotificationSettings">
        /// Email notification settings for this organization. Controls which email notifications users can receive. Structure: {"notifications_allowed": {"notification_type": bool}}
        /// </param>
        /// <param name="embedDomains">
        /// List of objects: {"domain": "example.com"}. Used for CSP header on /embed routes.
        /// </param>
        /// <param name="embedSettings">
        /// Embed settings for this organization
        /// </param>
        /// <param name="externalId">
        /// External ID to uniquely identify this organization
        /// </param>
        /// <param name="extraDataOnActivityLogs"></param>
        /// <param name="labelStreamNavigationDisabledAt">
        /// Set to current time to disable the label stream navigation for this organization. This will prevent users from going back in the label stream to view previous labels.
        /// </param>
        /// <param name="readOnlyQuickViewEnabledAt">
        /// Set to current time to prevent creating or editing annotations in quick view.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultRole(
            int organization,
            global::System.DateTime? annotatorReviewerFirewallEnabledAt,
            global::System.DateTime? customScriptsEnabledAt,
            global::G.Role9e7Enum? defaultRole1,
            object? emailNotificationSettings,
            object? embedDomains,
            object? embedSettings,
            string? externalId,
            bool? extraDataOnActivityLogs,
            global::System.DateTime? labelStreamNavigationDisabledAt,
            global::System.DateTime? readOnlyQuickViewEnabledAt)
        {
            this.AnnotatorReviewerFirewallEnabledAt = annotatorReviewerFirewallEnabledAt;
            this.CustomScriptsEnabledAt = customScriptsEnabledAt;
            this.DefaultRole1 = defaultRole1;
            this.EmailNotificationSettings = emailNotificationSettings;
            this.EmbedDomains = embedDomains;
            this.EmbedSettings = embedSettings;
            this.ExternalId = externalId;
            this.ExtraDataOnActivityLogs = extraDataOnActivityLogs;
            this.LabelStreamNavigationDisabledAt = labelStreamNavigationDisabledAt;
            this.Organization = organization;
            this.ReadOnlyQuickViewEnabledAt = readOnlyQuickViewEnabledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultRole" /> class.
        /// </summary>
        public DefaultRole()
        {
        }
    }
}