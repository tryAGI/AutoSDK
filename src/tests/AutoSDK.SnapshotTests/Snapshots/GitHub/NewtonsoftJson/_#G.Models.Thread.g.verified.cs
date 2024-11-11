//HintName: G.Models.Thread.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Thread
    /// </summary>
    public sealed partial class Thread
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MinimalRepository Repository { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subject", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ThreadSubject Subject { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unread", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Unread { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_read_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? LastReadAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/notifications/threads/2/subscription
        /// </summary>
        /// <example>https://api.github.com/notifications/threads/2/subscription</example>
        [global::Newtonsoft.Json.JsonProperty("subscription_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubscriptionUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Thread" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="subject"></param>
        /// <param name="reason"></param>
        /// <param name="unread"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastReadAt"></param>
        /// <param name="url"></param>
        /// <param name="subscriptionUrl">
        /// Example: https://api.github.com/notifications/threads/2/subscription
        /// </param>
        public Thread(
            string id,
            global::G.MinimalRepository repository,
            global::G.ThreadSubject subject,
            string reason,
            bool unread,
            string updatedAt,
            string? lastReadAt,
            string url,
            string subscriptionUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Unread = unread;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.LastReadAt = lastReadAt ?? throw new global::System.ArgumentNullException(nameof(lastReadAt));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.SubscriptionUrl = subscriptionUrl ?? throw new global::System.ArgumentNullException(nameof(subscriptionUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Thread" /> class.
        /// </summary>
        public Thread()
        {
        }
    }
}