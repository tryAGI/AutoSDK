//HintName: G.Models.RepositorySubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Repository invitations let you manage who you collaborate with.
    /// </summary>
    public sealed partial class RepositorySubscription
    {
        /// <summary>
        /// Determines if notifications should be received from this repository.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Subscribed { get; set; }

        /// <summary>
        /// Determines if all notifications should be blocked from this repository.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example/subscription
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example/subscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositorySubscription" /> class.
        /// </summary>
        /// <param name="subscribed">
        /// Determines if notifications should be received from this repository.<br/>
        /// Example: true
        /// </param>
        /// <param name="ignored">
        /// Determines if all notifications should be blocked from this repository.
        /// </param>
        /// <param name="reason"></param>
        /// <param name="createdAt"></param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/example/subscription
        /// </param>
        /// <param name="repositoryUrl">
        /// Example: https://api.github.com/repos/octocat/example
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositorySubscription(
            bool subscribed,
            bool ignored,
            string? reason,
            global::System.DateTime createdAt,
            string url,
            string repositoryUrl)
        {
            this.Subscribed = subscribed;
            this.Ignored = ignored;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.CreatedAt = createdAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositorySubscription" /> class.
        /// </summary>
        public RepositorySubscription()
        {
        }
    }
}