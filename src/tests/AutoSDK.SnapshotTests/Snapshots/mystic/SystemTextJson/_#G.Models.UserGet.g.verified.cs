//HintName: G.Models.UserGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class UserGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstname")]
        public string? Firstname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastname")]
        public string? Lastname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_colour")]
        public string? AvatarColour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_tutorial")]
        public bool? ShowTutorial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<global::G.UserTeam>? Teams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_team")]
        public string? SelectedTeam { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGet" /> class.
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="company"></param>
        /// <param name="jobTitle"></param>
        /// <param name="avatarColour"></param>
        /// <param name="showTutorial"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="id"></param>
        /// <param name="hasPassword"></param>
        /// <param name="roles"></param>
        /// <param name="teams"></param>
        /// <param name="selectedTeam"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGet(
            string email,
            string username,
            string id,
            bool hasPassword,
            string? firstname,
            string? lastname,
            string? company,
            string? jobTitle,
            string? avatarColour,
            bool? showTutorial,
            global::System.Collections.Generic.IList<string>? roles,
            global::System.Collections.Generic.IList<global::G.UserTeam>? teams,
            string? selectedTeam)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.HasPassword = hasPassword;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Company = company;
            this.JobTitle = jobTitle;
            this.AvatarColour = avatarColour;
            this.ShowTutorial = showTutorial;
            this.Roles = roles;
            this.Teams = teams;
            this.SelectedTeam = selectedTeam;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGet" /> class.
        /// </summary>
        public UserGet()
        {
        }
    }
}