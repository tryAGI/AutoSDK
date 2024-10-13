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
        [global::System.Text.Json.Serialization.JsonPropertyName("timeline_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TimelineUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/{user}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_public_url")]
        public string? CurrentUserPublicUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat.private?token=abc123
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_url")]
        public string? CurrentUserUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat.private.actor?token=abc123
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_actor_url")]
        public string? CurrentUserActorUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat-org
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_organization_url")]
        public string? CurrentUserOrganizationUrl { get; set; }

        /// <summary>
        /// Example: [https://github.com/organizations/github/octocat.private.atom?token=abc123]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_organization_urls")]
        public global::System.Collections.Generic.IList<string>? CurrentUserOrganizationUrls { get; set; }

        /// <summary>
        /// Example: https://github.com/security-advisories
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_advisories_url")]
        public string? SecurityAdvisoriesUrl { get; set; }

        /// <summary>
        /// A feed of discussions for a given repository.<br/>
        /// Example: https://github.com/{user}/{repo}/discussions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_discussions_url")]
        public string? RepositoryDiscussionsUrl { get; set; }

        /// <summary>
        /// A feed of discussions for a given repository and category.<br/>
        /// Example: https://github.com/{user}/{repo}/discussions/categories/{category}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_discussions_category_url")]
        public string? RepositoryDiscussionsCategoryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FeedLinks Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::G.Feed? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Feed),
                jsonSerializerContext) as global::G.Feed;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Feed? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Feed>(
                json,
                jsonSerializerOptions);
        }

    }
}