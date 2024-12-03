//HintName: G.Models.ThreadSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Thread Subscription
    /// </summary>
    public sealed partial class ThreadSubscription
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("subscribed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Subscribed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignored", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Ignored { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Reason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/notifications/threads/1/subscription
        /// </summary>
        /// <example>https://api.github.com/notifications/threads/1/subscription</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/notifications/threads/1
        /// </summary>
        /// <example>https://api.github.com/notifications/threads/1</example>
        [global::Newtonsoft.Json.JsonProperty("thread_url")]
        public string? ThreadUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/1
        /// </summary>
        /// <example>https://api.github.com/repos/1</example>
        [global::Newtonsoft.Json.JsonProperty("repository_url")]
        public string? RepositoryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadSubscription" /> class.
        /// </summary>
        /// <param name="subscribed">
        /// Example: true
        /// </param>
        /// <param name="ignored"></param>
        /// <param name="reason"></param>
        /// <param name="createdAt"></param>
        /// <param name="url">
        /// Example: https://api.github.com/notifications/threads/1/subscription
        /// </param>
        /// <param name="threadUrl">
        /// Example: https://api.github.com/notifications/threads/1
        /// </param>
        /// <param name="repositoryUrl">
        /// Example: https://api.github.com/repos/1
        /// </param>
        public ThreadSubscription(
            bool subscribed,
            bool ignored,
            string? reason,
            global::System.DateTime? createdAt,
            string url,
            string? threadUrl,
            string? repositoryUrl)
        {
            this.Subscribed = subscribed;
            this.Ignored = ignored;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.CreatedAt = createdAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ThreadUrl = threadUrl;
            this.RepositoryUrl = repositoryUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadSubscription" /> class.
        /// </summary>
        public ThreadSubscription()
        {
        }
    }
}