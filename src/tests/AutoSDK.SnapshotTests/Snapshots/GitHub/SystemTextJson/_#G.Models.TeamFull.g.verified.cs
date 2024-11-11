//HintName: G.Models.TeamFull.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public sealed partial class TeamFull
    {
        /// <summary>
        /// Unique identifier of the team<br/>
        /// Example: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDQ6VGVhbTE=
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// URL for the team<br/>
        /// Example: https://api.github.com/organizations/1/team/1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/orgs/rails/teams/core
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Name of the team<br/>
        /// Example: Developers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: justice-league
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Example: A great team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// The level of privacy this team should have<br/>
        /// Example: closed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TeamFullPrivacyJsonConverter))]
        public global::G.TeamFullPrivacy? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has set<br/>
        /// Example: notifications_enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TeamFullNotificationSettingJsonConverter))]
        public global::G.TeamFullNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// Permission that the team will have for its repositories<br/>
        /// Example: push
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permission { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/1/members{/member}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MembersUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/1/repos
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoriesUrl { get; set; }

        /// <summary>
        /// Groups of organization members that gives permissions on specified repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public global::G.NullableTeamSimple? Parent { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MembersCount { get; set; }

        /// <summary>
        /// Example: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReposCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Team Organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TeamOrganization Organization { get; set; }

        /// <summary>
        /// Distinguished Name (DN) that team maps to within LDAP environment<br/>
        /// Example: uid=example,ou=users,dc=github,dc=com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ldap_dn")]
        public string? LdapDn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFull" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the team<br/>
        /// Example: 42
        /// </param>
        /// <param name="nodeId">
        /// Example: MDQ6VGVhbTE=
        /// </param>
        /// <param name="url">
        /// URL for the team<br/>
        /// Example: https://api.github.com/organizations/1/team/1
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/orgs/rails/teams/core
        /// </param>
        /// <param name="name">
        /// Name of the team<br/>
        /// Example: Developers
        /// </param>
        /// <param name="slug">
        /// Example: justice-league
        /// </param>
        /// <param name="description">
        /// Example: A great team.
        /// </param>
        /// <param name="privacy">
        /// The level of privacy this team should have<br/>
        /// Example: closed
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team has set<br/>
        /// Example: notifications_enabled
        /// </param>
        /// <param name="permission">
        /// Permission that the team will have for its repositories<br/>
        /// Example: push
        /// </param>
        /// <param name="membersUrl">
        /// Example: https://api.github.com/organizations/1/team/1/members{/member}
        /// </param>
        /// <param name="repositoriesUrl">
        /// Example: https://api.github.com/organizations/1/team/1/repos
        /// </param>
        /// <param name="parent">
        /// Groups of organization members that gives permissions on specified repositories.
        /// </param>
        /// <param name="membersCount">
        /// Example: 3
        /// </param>
        /// <param name="reposCount">
        /// Example: 10
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="organization">
        /// Team Organization
        /// </param>
        /// <param name="ldapDn">
        /// Distinguished Name (DN) that team maps to within LDAP environment<br/>
        /// Example: uid=example,ou=users,dc=github,dc=com
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TeamFull(
            int id,
            string nodeId,
            string url,
            string htmlUrl,
            string name,
            string slug,
            string? description,
            string permission,
            string membersUrl,
            string repositoriesUrl,
            int membersCount,
            int reposCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.TeamOrganization organization,
            global::G.TeamFullPrivacy? privacy,
            global::G.TeamFullNotificationSetting? notificationSetting,
            global::G.NullableTeamSimple? parent,
            string? ldapDn)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.RepositoriesUrl = repositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(repositoriesUrl));
            this.MembersCount = membersCount;
            this.ReposCount = reposCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Parent = parent;
            this.LdapDn = ldapDn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFull" /> class.
        /// </summary>
        public TeamFull()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.TeamFull? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.TeamFull),
                jsonSerializerContext) as global::G.TeamFull;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.TeamFull? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.TeamFull>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.TeamFull?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.TeamFull),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.TeamFull;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.TeamFull?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.TeamFull?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}