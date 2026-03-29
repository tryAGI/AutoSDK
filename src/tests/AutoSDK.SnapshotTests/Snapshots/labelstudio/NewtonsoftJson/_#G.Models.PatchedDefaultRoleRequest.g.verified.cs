//HintName: G.Models.PatchedDefaultRoleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedDefaultRoleRequest
    {
        /// <summary>
        /// Set to current time to restrict data sharing between annotators and reviewers in the label stream, review stream, and notifications (which will be disabled). In these settings, information about annotator and reviewer identity is suppressed in the UI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotator_reviewer_firewall_enabled_at")]
        public global::System.DateTime? AnnotatorReviewerFirewallEnabledAt { get; set; }

        /// <summary>
        /// Set to current time to enable custom scripts (Plugins) for this organization. Can only be enabled if no organization members are active members of any other organizations; otherwise an error will be raised. If this occurs, contact the LEAP team for assistance with enabling custom scripts (Plugins).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_scripts_enabled_at")]
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
        [global::Newtonsoft.Json.JsonProperty("default_role")]
        public global::G.Role9e7Enum? DefaultRole { get; set; }

        /// <summary>
        /// Email notification settings for this organization. Controls which email notifications users can receive. Structure: {"notifications_allowed": {"notification_type": bool}}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email_notification_settings")]
        public object? EmailNotificationSettings { get; set; }

        /// <summary>
        /// List of objects: {"domain": "example.com"}. Used for CSP header on /embed routes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_domains")]
        public object? EmbedDomains { get; set; }

        /// <summary>
        /// Embed settings for this organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_settings")]
        public object? EmbedSettings { get; set; }

        /// <summary>
        /// External ID to uniquely identify this organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_data_on_activity_logs")]
        public bool? ExtraDataOnActivityLogs { get; set; }

        /// <summary>
        /// Set to current time to disable the label stream navigation for this organization. This will prevent users from going back in the label stream to view previous labels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label_stream_navigation_disabled_at")]
        public global::System.DateTime? LabelStreamNavigationDisabledAt { get; set; }

        /// <summary>
        /// A unique integer value identifying this organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Set to current time to prevent creating or editing annotations in quick view.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only_quick_view_enabled_at")]
        public global::System.DateTime? ReadOnlyQuickViewEnabledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDefaultRoleRequest" /> class.
        /// </summary>
        /// <param name="annotatorReviewerFirewallEnabledAt">
        /// Set to current time to restrict data sharing between annotators and reviewers in the label stream, review stream, and notifications (which will be disabled). In these settings, information about annotator and reviewer identity is suppressed in the UI.
        /// </param>
        /// <param name="customScriptsEnabledAt">
        /// Set to current time to enable custom scripts (Plugins) for this organization. Can only be enabled if no organization members are active members of any other organizations; otherwise an error will be raised. If this occurs, contact the LEAP team for assistance with enabling custom scripts (Plugins).
        /// </param>
        /// <param name="defaultRole">
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
        /// <param name="organization">
        /// A unique integer value identifying this organization.
        /// </param>
        /// <param name="readOnlyQuickViewEnabledAt">
        /// Set to current time to prevent creating or editing annotations in quick view.
        /// </param>
        public PatchedDefaultRoleRequest(
            global::System.DateTime? annotatorReviewerFirewallEnabledAt,
            global::System.DateTime? customScriptsEnabledAt,
            global::G.Role9e7Enum? defaultRole,
            object? emailNotificationSettings,
            object? embedDomains,
            object? embedSettings,
            string? externalId,
            bool? extraDataOnActivityLogs,
            global::System.DateTime? labelStreamNavigationDisabledAt,
            int? organization,
            global::System.DateTime? readOnlyQuickViewEnabledAt)
        {
            this.AnnotatorReviewerFirewallEnabledAt = annotatorReviewerFirewallEnabledAt;
            this.CustomScriptsEnabledAt = customScriptsEnabledAt;
            this.DefaultRole = defaultRole;
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
        /// Initializes a new instance of the <see cref="PatchedDefaultRoleRequest" /> class.
        /// </summary>
        public PatchedDefaultRoleRequest()
        {
        }
    }
}