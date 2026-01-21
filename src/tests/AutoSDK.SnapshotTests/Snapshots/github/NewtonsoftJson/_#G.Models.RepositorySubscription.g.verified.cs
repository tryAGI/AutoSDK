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
        [global::Newtonsoft.Json.JsonProperty("subscribed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Subscribed { get; set; } = default!;

        /// <summary>
        /// Determines if all notifications should be blocked from this repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignored", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Ignored { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Reason { get; set; } = default!;

        /// <summary>
        /// Example: 2012-10-06T21:34:12Z
        /// </summary>
        /// <example>2012-10-06T21:34:12Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example/subscription
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example/subscription</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example</example>
        [global::Newtonsoft.Json.JsonProperty("repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepositoryUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="createdAt">
        /// Example: 2012-10-06T21:34:12Z
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/example/subscription
        /// </param>
        /// <param name="repositoryUrl">
        /// Example: https://api.github.com/repos/octocat/example
        /// </param>
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