//HintName: G.Models.WebhookPageBuildBuild.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [List GitHub Pages builds](https://docs.github.com/rest/pages/pages#list-github-pages-builds) itself.
    /// </summary>
    public sealed partial class WebhookPageBuildBuild
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Commit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public int Duration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPageBuildBuildError Error { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pusher", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPageBuildBuildPusher? Pusher { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPageBuildBuild" /> class.
        /// </summary>
        /// <param name="commit"></param>
        /// <param name="createdAt"></param>
        /// <param name="duration"></param>
        /// <param name="error"></param>
        /// <param name="pusher"></param>
        /// <param name="status"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        public WebhookPageBuildBuild(
            string? commit,
            string createdAt,
            int duration,
            global::G.WebhookPageBuildBuildError error,
            global::G.WebhookPageBuildBuildPusher? pusher,
            string status,
            string updatedAt,
            string url)
        {
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Duration = duration;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Pusher = pusher ?? throw new global::System.ArgumentNullException(nameof(pusher));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPageBuildBuild" /> class.
        /// </summary>
        public WebhookPageBuildBuild()
        {
        }
    }
}