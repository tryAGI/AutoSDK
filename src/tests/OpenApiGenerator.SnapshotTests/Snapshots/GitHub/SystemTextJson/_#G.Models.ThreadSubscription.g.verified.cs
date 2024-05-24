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
        /// <br/>Example: true
        /// </summary>
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
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/notifications/threads/1/subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/notifications/threads/1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_url")]
        public string? ThreadUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        public string? RepositoryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}