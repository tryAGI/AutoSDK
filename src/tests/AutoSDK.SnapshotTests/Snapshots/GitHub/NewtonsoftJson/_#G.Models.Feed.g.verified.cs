//HintName: G.Models.Feed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feed
    /// </summary>
    public sealed partial class Feed
    {
        /// <summary>
        /// Example: https://github.com/timeline
        /// </summary>
        /// <example>https://github.com/timeline</example>
        [global::Newtonsoft.Json.JsonProperty("timeline_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TimelineUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/{user}
        /// </summary>
        /// <example>https://github.com/{user}</example>
        [global::Newtonsoft.Json.JsonProperty("user_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        /// <example>https://github.com/octocat</example>
        [global::Newtonsoft.Json.JsonProperty("current_user_public_url")]
        public string? CurrentUserPublicUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat.private?token=abc123
        /// </summary>
        /// <example>https://github.com/octocat.private?token=abc123</example>
        [global::Newtonsoft.Json.JsonProperty("current_user_url")]
        public string? CurrentUserUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat.private.actor?token=abc123
        /// </summary>
        /// <example>https://github.com/octocat.private.actor?token=abc123</example>
        [global::Newtonsoft.Json.JsonProperty("current_user_actor_url")]
        public string? CurrentUserActorUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat-org
        /// </summary>
        /// <example>https://github.com/octocat-org</example>
        [global::Newtonsoft.Json.JsonProperty("current_user_organization_url")]
        public string? CurrentUserOrganizationUrl { get; set; }

        /// <summary>
        /// Example: [https://github.com/organizations/github/octocat.private.atom?token=abc123]
        /// </summary>
        /// <example>[https://github.com/organizations/github/octocat.private.atom?token=abc123]</example>
        [global::Newtonsoft.Json.JsonProperty("current_user_organization_urls")]
        public global::System.Collections.Generic.IList<string>? CurrentUserOrganizationUrls { get; set; }

        /// <summary>
        /// Example: https://github.com/security-advisories
        /// </summary>
        /// <example>https://github.com/security-advisories</example>
        [global::Newtonsoft.Json.JsonProperty("security_advisories_url")]
        public string? SecurityAdvisoriesUrl { get; set; }

        /// <summary>
        /// A feed of discussions for a given repository.<br/>
        /// Example: https://github.com/{user}/{repo}/discussions
        /// </summary>
        /// <example>https://github.com/{user}/{repo}/discussions</example>
        [global::Newtonsoft.Json.JsonProperty("repository_discussions_url")]
        public string? RepositoryDiscussionsUrl { get; set; }

        /// <summary>
        /// A feed of discussions for a given repository and category.<br/>
        /// Example: https://github.com/{user}/{repo}/discussions/categories/{category}
        /// </summary>
        /// <example>https://github.com/{user}/{repo}/discussions/categories/{category}</example>
        [global::Newtonsoft.Json.JsonProperty("repository_discussions_category_url")]
        public string? RepositoryDiscussionsCategoryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FeedLinks Links { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Feed" /> class.
        /// </summary>
        /// <param name="timelineUrl">
        /// Example: https://github.com/timeline
        /// </param>
        /// <param name="userUrl">
        /// Example: https://github.com/{user}
        /// </param>
        /// <param name="currentUserPublicUrl">
        /// Example: https://github.com/octocat
        /// </param>
        /// <param name="currentUserUrl">
        /// Example: https://github.com/octocat.private?token=abc123
        /// </param>
        /// <param name="currentUserActorUrl">
        /// Example: https://github.com/octocat.private.actor?token=abc123
        /// </param>
        /// <param name="currentUserOrganizationUrl">
        /// Example: https://github.com/octocat-org
        /// </param>
        /// <param name="currentUserOrganizationUrls">
        /// Example: [https://github.com/organizations/github/octocat.private.atom?token=abc123]
        /// </param>
        /// <param name="securityAdvisoriesUrl">
        /// Example: https://github.com/security-advisories
        /// </param>
        /// <param name="repositoryDiscussionsUrl">
        /// A feed of discussions for a given repository.<br/>
        /// Example: https://github.com/{user}/{repo}/discussions
        /// </param>
        /// <param name="repositoryDiscussionsCategoryUrl">
        /// A feed of discussions for a given repository and category.<br/>
        /// Example: https://github.com/{user}/{repo}/discussions/categories/{category}
        /// </param>
        /// <param name="links"></param>
        public Feed(
            string timelineUrl,
            string userUrl,
            global::G.FeedLinks links,
            string? currentUserPublicUrl,
            string? currentUserUrl,
            string? currentUserActorUrl,
            string? currentUserOrganizationUrl,
            global::System.Collections.Generic.IList<string>? currentUserOrganizationUrls,
            string? securityAdvisoriesUrl,
            string? repositoryDiscussionsUrl,
            string? repositoryDiscussionsCategoryUrl)
        {
            this.TimelineUrl = timelineUrl ?? throw new global::System.ArgumentNullException(nameof(timelineUrl));
            this.UserUrl = userUrl ?? throw new global::System.ArgumentNullException(nameof(userUrl));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.CurrentUserPublicUrl = currentUserPublicUrl;
            this.CurrentUserUrl = currentUserUrl;
            this.CurrentUserActorUrl = currentUserActorUrl;
            this.CurrentUserOrganizationUrl = currentUserOrganizationUrl;
            this.CurrentUserOrganizationUrls = currentUserOrganizationUrls;
            this.SecurityAdvisoriesUrl = securityAdvisoriesUrl;
            this.RepositoryDiscussionsUrl = repositoryDiscussionsUrl;
            this.RepositoryDiscussionsCategoryUrl = repositoryDiscussionsCategoryUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Feed" /> class.
        /// </summary>
        public Feed()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Feed? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Feed>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Feed?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Feed?>(serializer.Deserialize<global::G.Feed>(jsonReader));
        }

    }
}