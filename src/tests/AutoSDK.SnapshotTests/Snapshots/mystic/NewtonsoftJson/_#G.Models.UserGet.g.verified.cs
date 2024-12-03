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
        [global::Newtonsoft.Json.JsonProperty("firstname")]
        public string? Firstname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastname")]
        public string? Lastname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public string? Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_title")]
        public string? JobTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_colour")]
        public string? AvatarColour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_tutorial")]
        public bool? ShowTutorial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_password", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasPassword { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams")]
        public global::System.Collections.Generic.IList<global::G.UserTeam>? Teams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_team")]
        public string? SelectedTeam { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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