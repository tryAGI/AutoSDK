//HintName: G.Models.SimpleClassroomUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub user simplified for Classroom.
    /// </summary>
    public sealed partial class SimpleClassroomUser
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: octocat
        /// </summary>
        /// <example>octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        /// <example>https://github.com/images/error/octocat_happy.gif</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        /// <example>https://github.com/octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleClassroomUser" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="login">
        /// Example: octocat
        /// </param>
        /// <param name="avatarUrl">
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimpleClassroomUser(
            int id,
            string login,
            string avatarUrl,
            string htmlUrl)
        {
            this.Id = id;
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleClassroomUser" /> class.
        /// </summary>
        public SimpleClassroomUser()
        {
        }
    }
}