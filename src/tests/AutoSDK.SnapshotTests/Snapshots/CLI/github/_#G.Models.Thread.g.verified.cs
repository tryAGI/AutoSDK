﻿//HintName: G.Models.Thread.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MinimalRepository Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ThreadSubject Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unread")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Unread { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_read_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? LastReadAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/notifications/threads/2/subscription
        /// </summary>
        /// <example>https://api.github.com/notifications/threads/2/subscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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