//HintName: G.Models.SimpleClassroomOrganization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub organization.
    /// </summary>
    public sealed partial class SimpleClassroomOrganization
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </summary>
        /// <example>MDEyOk9yZ2FuaXphdGlvbjE=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: https://github.com/github
        /// </summary>
        /// <example>https://github.com/github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: Github - Code thigns happen here
        /// </summary>
        /// <example>Github - Code thigns happen here</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Name { get; set; }

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        /// <example>https://github.com/images/error/octocat_happy.gif</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleClassroomOrganization" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="login">
        /// Example: github
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/github
        /// </param>
        /// <param name="name">
        /// Example: Github - Code thigns happen here
        /// </param>
        /// <param name="avatarUrl">
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SimpleClassroomOrganization(
            int id,
            string login,
            string nodeId,
            string htmlUrl,
            string? name,
            string avatarUrl)
        {
            this.Id = id;
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleClassroomOrganization" /> class.
        /// </summary>
        public SimpleClassroomOrganization()
        {
        }
    }
}