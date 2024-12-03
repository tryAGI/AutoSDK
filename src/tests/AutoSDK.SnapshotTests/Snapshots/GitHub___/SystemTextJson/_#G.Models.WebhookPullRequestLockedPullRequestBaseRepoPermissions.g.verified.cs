//HintName: G.Models.WebhookPullRequestLockedPullRequestBaseRepoPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestLockedPullRequestBaseRepoPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Admin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintain")]
        public bool? Maintain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pull { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Push { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triage")]
        public bool? Triage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestLockedPullRequestBaseRepoPermissions" /> class.
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="maintain"></param>
        /// <param name="pull"></param>
        /// <param name="push"></param>
        /// <param name="triage"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookPullRequestLockedPullRequestBaseRepoPermissions(
            bool admin,
            bool pull,
            bool push,
            bool? maintain,
            bool? triage)
        {
            this.Admin = admin;
            this.Pull = pull;
            this.Push = push;
            this.Maintain = maintain;
            this.Triage = triage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestLockedPullRequestBaseRepoPermissions" /> class.
        /// </summary>
        public WebhookPullRequestLockedPullRequestBaseRepoPermissions()
        {
        }
    }
}