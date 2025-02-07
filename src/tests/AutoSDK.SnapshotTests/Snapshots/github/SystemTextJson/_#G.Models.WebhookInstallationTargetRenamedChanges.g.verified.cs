//HintName: G.Models.WebhookInstallationTargetRenamedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInstallationTargetRenamedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public global::G.WebhookInstallationTargetRenamedChangesLogin? Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public global::G.WebhookInstallationTargetRenamedChangesSlug? Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationTargetRenamedChanges" /> class.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="slug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookInstallationTargetRenamedChanges(
            global::G.WebhookInstallationTargetRenamedChangesLogin? login,
            global::G.WebhookInstallationTargetRenamedChangesSlug? slug)
        {
            this.Login = login;
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationTargetRenamedChanges" /> class.
        /// </summary>
        public WebhookInstallationTargetRenamedChanges()
        {
        }
    }
}