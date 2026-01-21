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
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Subscribed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ignored { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Reason { get; set; }

        /// <summary>
        /// Example: 2012-10-06T21:34:12Z
        /// </summary>
        /// <example>2012-10-06T21:34:12Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example: https://api.github.com/notifications/threads/1/subscription
        /// </summary>
        /// <example>https://api.github.com/notifications/threads/1/subscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/notifications/threads/1
        /// </summary>
        /// <example>https://api.github.com/notifications/threads/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_url")]
        public string? ThreadUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/1
        /// </summary>
        /// <example>https://api.github.com/repos/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        public string? RepositoryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadSubscription" /> class.
        /// </summary>
        /// <param name="subscribed">
        /// Example: true
        /// </param>
        /// <param name="ignored"></param>
        /// <param name="reason"></param>
        /// <param name="createdAt">
        /// Example: 2012-10-06T21:34:12Z
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/notifications/threads/1/subscription
        /// </param>
        /// <param name="threadUrl">
        /// Example: https://api.github.com/notifications/threads/1
        /// </param>
        /// <param name="repositoryUrl">
        /// Example: https://api.github.com/repos/1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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