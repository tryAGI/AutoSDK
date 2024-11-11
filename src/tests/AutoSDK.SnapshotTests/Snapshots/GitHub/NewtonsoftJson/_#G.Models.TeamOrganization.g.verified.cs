//HintName: G.Models.TeamOrganization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Team Organization
    /// </summary>
    public sealed partial class TeamOrganization
    {
        /// <summary>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </summary>
        /// <example>MDEyOk9yZ2FuaXphdGlvbjE=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github
        /// </summary>
        /// <example>https://api.github.com/orgs/github</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/repos
        /// </summary>
        /// <example>https://api.github.com/orgs/github/repos</example>
        [global::Newtonsoft.Json.JsonProperty("repos_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReposUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/events
        /// </summary>
        /// <example>https://api.github.com/orgs/github/events</example>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/hooks
        /// </summary>
        /// <example>https://api.github.com/orgs/github/hooks</example>
        [global::Newtonsoft.Json.JsonProperty("hooks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HooksUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/issues
        /// </summary>
        /// <example>https://api.github.com/orgs/github/issues</example>
        [global::Newtonsoft.Json.JsonProperty("issues_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssuesUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/members{/member}
        /// </summary>
        /// <example>https://api.github.com/orgs/github/members{/member}</example>
        [global::Newtonsoft.Json.JsonProperty("members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MembersUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/github/public_members{/member}
        /// </summary>
        /// <example>https://api.github.com/orgs/github/public_members{/member}</example>
        [global::Newtonsoft.Json.JsonProperty("public_members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicMembersUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        /// <example>https://github.com/images/error/octocat_happy.gif</example>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// Example: A great organization
        /// </summary>
        /// <example>A great organization</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: GitHub
        /// </summary>
        /// <example>GitHub</example>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Example: https://github.com/blog
        /// </summary>
        /// <example>https://github.com/blog</example>
        [global::Newtonsoft.Json.JsonProperty("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// Example: San Francisco
        /// </summary>
        /// <example>San Francisco</example>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        /// <example>octocat@github.com</example>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::Newtonsoft.Json.JsonProperty("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("is_verified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("has_organization_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasOrganizationProjects { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("has_repository_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasRepositoryProjects { get; set; } = default!;

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("public_repos", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicRepos { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("public_gists", Required = global::Newtonsoft.Json.Required.Always)]
        public int PublicGists { get; set; } = default!;

        /// <summary>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::Newtonsoft.Json.JsonProperty("followers", Required = global::Newtonsoft.Json.Required.Always)]
        public int Followers { get; set; } = default!;

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("following", Required = global::Newtonsoft.Json.Required.Always)]
        public int Following { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        /// <example>https://github.com/octocat</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: Organization
        /// </summary>
        /// <example>Organization</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("total_private_repos")]
        public int? TotalPrivateRepos { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("owned_private_repos")]
        public int? OwnedPrivateRepos { get; set; }

        /// <summary>
        /// Example: 81
        /// </summary>
        /// <example>81</example>
        [global::Newtonsoft.Json.JsonProperty("private_gists")]
        public int? PrivateGists { get; set; }

        /// <summary>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::Newtonsoft.Json.JsonProperty("disk_usage")]
        public int? DiskUsage { get; set; }

        /// <summary>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::Newtonsoft.Json.JsonProperty("collaborators")]
        public int? Collaborators { get; set; }

        /// <summary>
        /// Example: org@example.com
        /// </summary>
        /// <example>org@example.com</example>
        [global::Newtonsoft.Json.JsonProperty("billing_email")]
        public string? BillingEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public global::G.TeamOrganizationPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_repository_permission")]
        public string? DefaultRepositoryPermission { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_repositories")]
        public bool? MembersCanCreateRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("two_factor_requirement_enabled")]
        public bool? TwoFactorRequirementEnabled { get; set; }

        /// <summary>
        /// Example: all
        /// </summary>
        /// <example>all</example>
        [global::Newtonsoft.Json.JsonProperty("members_allowed_repository_creation_type")]
        public string? MembersAllowedRepositoryCreationType { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_public_repositories")]
        public bool? MembersCanCreatePublicRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_private_repositories")]
        public bool? MembersCanCreatePrivateRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_internal_repositories")]
        public bool? MembersCanCreateInternalRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_pages")]
        public bool? MembersCanCreatePages { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_public_pages")]
        public bool? MembersCanCreatePublicPages { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("members_can_create_private_pages")]
        public bool? MembersCanCreatePrivatePages { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("members_can_fork_private_repositories")]
        public bool? MembersCanForkPrivateRepositories { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ArchivedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamOrganization" /> class.
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
        /// <param name="name">
        /// Example: github
        /// </param>
        /// <param name="company">
        /// Example: GitHub
        /// </param>
        /// <param name="blog">
        /// Example: https://github.com/blog
        /// </param>
        /// <param name="location">
        /// Example: San Francisco
        /// </param>
        /// <param name="email">
        /// Example: octocat@github.com
        /// </param>
        /// <param name="twitterUsername">
        /// Example: github
        /// </param>
        /// <param name="isVerified">
        /// Example: true
        /// </param>
        /// <param name="hasOrganizationProjects">
        /// Example: true
        /// </param>
        /// <param name="hasRepositoryProjects">
        /// Example: true
        /// </param>
        /// <param name="publicRepos">
        /// Example: 2
        /// </param>
        /// <param name="publicGists">
        /// Example: 1
        /// </param>
        /// <param name="followers">
        /// Example: 20
        /// </param>
        /// <param name="following">
        /// Example: 0
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="type">
        /// Example: Organization
        /// </param>
        /// <param name="totalPrivateRepos">
        /// Example: 100
        /// </param>
        /// <param name="ownedPrivateRepos">
        /// Example: 100
        /// </param>
        /// <param name="privateGists">
        /// Example: 81
        /// </param>
        /// <param name="diskUsage">
        /// Example: 10000
        /// </param>
        /// <param name="collaborators">
        /// Example: 8
        /// </param>
        /// <param name="billingEmail">
        /// Example: org@example.com
        /// </param>
        /// <param name="plan"></param>
        /// <param name="defaultRepositoryPermission"></param>
        /// <param name="membersCanCreateRepositories">
        /// Example: true
        /// </param>
        /// <param name="twoFactorRequirementEnabled">
        /// Example: true
        /// </param>
        /// <param name="membersAllowedRepositoryCreationType">
        /// Example: all
        /// </param>
        /// <param name="membersCanCreatePublicRepositories">
        /// Example: true
        /// </param>
        /// <param name="membersCanCreatePrivateRepositories">
        /// Example: true
        /// </param>
        /// <param name="membersCanCreateInternalRepositories">
        /// Example: true
        /// </param>
        /// <param name="membersCanCreatePages">
        /// Example: true
        /// </param>
        /// <param name="membersCanCreatePublicPages">
        /// Example: true
        /// </param>
        /// <param name="membersCanCreatePrivatePages">
        /// Example: true
        /// </param>
        /// <param name="membersCanForkPrivateRepositories">
        /// Example: false
        /// </param>
        /// <param name="webCommitSignoffRequired">
        /// Example: false
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="archivedAt"></param>
        public TeamOrganization(
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
            string? description,
            bool hasOrganizationProjects,
            bool hasRepositoryProjects,
            int publicRepos,
            int publicGists,
            int followers,
            int following,
            string htmlUrl,
            global::System.DateTime createdAt,
            string type,
            global::System.DateTime updatedAt,
            global::System.DateTime? archivedAt,
            string? name,
            string? company,
            string? blog,
            string? location,
            string? email,
            string? twitterUsername,
            bool? isVerified,
            int? totalPrivateRepos,
            int? ownedPrivateRepos,
            int? privateGists,
            int? diskUsage,
            int? collaborators,
            string? billingEmail,
            global::G.TeamOrganizationPlan? plan,
            string? defaultRepositoryPermission,
            bool? membersCanCreateRepositories,
            bool? twoFactorRequirementEnabled,
            string? membersAllowedRepositoryCreationType,
            bool? membersCanCreatePublicRepositories,
            bool? membersCanCreatePrivateRepositories,
            bool? membersCanCreateInternalRepositories,
            bool? membersCanCreatePages,
            bool? membersCanCreatePublicPages,
            bool? membersCanCreatePrivatePages,
            bool? membersCanForkPrivateRepositories,
            bool? webCommitSignoffRequired)
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
            this.HasOrganizationProjects = hasOrganizationProjects;
            this.HasRepositoryProjects = hasRepositoryProjects;
            this.PublicRepos = publicRepos;
            this.PublicGists = publicGists;
            this.Followers = followers;
            this.Following = following;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.CreatedAt = createdAt;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
            this.Name = name;
            this.Company = company;
            this.Blog = blog;
            this.Location = location;
            this.Email = email;
            this.TwitterUsername = twitterUsername;
            this.IsVerified = isVerified;
            this.TotalPrivateRepos = totalPrivateRepos;
            this.OwnedPrivateRepos = ownedPrivateRepos;
            this.PrivateGists = privateGists;
            this.DiskUsage = diskUsage;
            this.Collaborators = collaborators;
            this.BillingEmail = billingEmail;
            this.Plan = plan;
            this.DefaultRepositoryPermission = defaultRepositoryPermission;
            this.MembersCanCreateRepositories = membersCanCreateRepositories;
            this.TwoFactorRequirementEnabled = twoFactorRequirementEnabled;
            this.MembersAllowedRepositoryCreationType = membersAllowedRepositoryCreationType;
            this.MembersCanCreatePublicRepositories = membersCanCreatePublicRepositories;
            this.MembersCanCreatePrivateRepositories = membersCanCreatePrivateRepositories;
            this.MembersCanCreateInternalRepositories = membersCanCreateInternalRepositories;
            this.MembersCanCreatePages = membersCanCreatePages;
            this.MembersCanCreatePublicPages = membersCanCreatePublicPages;
            this.MembersCanCreatePrivatePages = membersCanCreatePrivatePages;
            this.MembersCanForkPrivateRepositories = membersCanForkPrivateRepositories;
            this.WebCommitSignoffRequired = webCommitSignoffRequired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamOrganization" /> class.
        /// </summary>
        public TeamOrganization()
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
        public static global::G.TeamOrganization? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TeamOrganization>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.TeamOrganization?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.TeamOrganization?>(serializer.Deserialize<global::G.TeamOrganization>(jsonReader));
        }

    }
}