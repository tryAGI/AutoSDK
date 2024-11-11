//HintName: G.Models.NullableOrganizationSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub organization.
    /// </summary>
    public sealed partial class NullableOrganizationSimple
    {
        /// <summary>
        /// Example: github
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/repos
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReposUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/hooks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HooksUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/issues
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssuesUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/members{/member}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MembersUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/public_members{/member}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicMembersUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// Example: A great organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableOrganizationSimple" /> class.
        /// </summary>
        /// <param name="login">
        /// Example: github
        /// </param>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/github
        /// </param>
        /// <param name="reposUrl">
        /// Example: https://api.github.com/orgs/github/repos
        /// </param>
        /// <param name="eventsUrl">
        /// Example: https://api.github.com/orgs/github/events
        /// </param>
        /// <param name="hooksUrl">
        /// Example: https://api.github.com/orgs/github/hooks
        /// </param>
        /// <param name="issuesUrl">
        /// Example: https://api.github.com/orgs/github/issues
        /// </param>
        /// <param name="membersUrl">
        /// Example: https://api.github.com/orgs/github/members{/member}
        /// </param>
        /// <param name="publicMembersUrl">
        /// Example: https://api.github.com/orgs/github/public_members{/member}
        /// </param>
        /// <param name="avatarUrl">
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </param>
        /// <param name="description">
        /// Example: A great organization
        /// </param>
        public NullableOrganizationSimple(
            string login,
            int id,
            string nodeId,
            string url,
            string reposUrl,
            string eventsUrl,
            string hooksUrl,
            string issuesUrl,
            string membersUrl,
            string publicMembersUrl,
            string avatarUrl,
            string? description)
        {
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ReposUrl = reposUrl ?? throw new global::System.ArgumentNullException(nameof(reposUrl));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.HooksUrl = hooksUrl ?? throw new global::System.ArgumentNullException(nameof(hooksUrl));
            this.IssuesUrl = issuesUrl ?? throw new global::System.ArgumentNullException(nameof(issuesUrl));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.PublicMembersUrl = publicMembersUrl ?? throw new global::System.ArgumentNullException(nameof(publicMembersUrl));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableOrganizationSimple" /> class.
        /// </summary>
        public NullableOrganizationSimple()
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
        public static global::G.NullableOrganizationSimple? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.NullableOrganizationSimple>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.NullableOrganizationSimple?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.NullableOrganizationSimple?>(serializer.Deserialize<global::G.NullableOrganizationSimple>(jsonReader));
        }

    }
}