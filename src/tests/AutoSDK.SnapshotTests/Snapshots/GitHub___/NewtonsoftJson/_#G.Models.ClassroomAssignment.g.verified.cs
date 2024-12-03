//HintName: G.Models.ClassroomAssignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub Classroom assignment
    /// </summary>
    public sealed partial class ClassroomAssignment
    {
        /// <summary>
        /// Unique identifier of the repository.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Whether an accepted assignment creates a public repository.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("public_repo", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PublicRepo { get; set; } = default!;

        /// <summary>
        /// Assignment title.<br/>
        /// Example: Intro to Binaries
        /// </summary>
        /// <example>Intro to Binaries</example>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Whether it's a group assignment or individual assignment.<br/>
        /// Example: individual
        /// </summary>
        /// <example>individual</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClassroomAssignmentType Type { get; set; } = default!;

        /// <summary>
        /// The link that a student can use to accept the assignment.<br/>
        /// Example: https://classroom.github.com/a/Lx7jiUgx
        /// </summary>
        /// <example>https://classroom.github.com/a/Lx7jiUgx</example>
        [global::Newtonsoft.Json.JsonProperty("invite_link", Required = global::Newtonsoft.Json.Required.Always)]
        public string InviteLink { get; set; } = default!;

        /// <summary>
        /// Whether the invitation link is enabled. Visiting an enabled invitation link will accept the assignment.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("invitations_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool InvitationsEnabled { get; set; } = default!;

        /// <summary>
        /// Sluggified name of the assignment.<br/>
        /// Example: intro-to-binaries
        /// </summary>
        /// <example>intro-to-binaries</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Whether students are admins on created repository when a student accepts the assignment.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("students_are_repo_admins", Required = global::Newtonsoft.Json.Required.Always)]
        public bool StudentsAreRepoAdmins { get; set; } = default!;

        /// <summary>
        /// Whether feedback pull request will be created when a student accepts the assignment.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("feedback_pull_requests_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool FeedbackPullRequestsEnabled { get; set; } = default!;

        /// <summary>
        /// The maximum allowable teams for the assignment.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("max_teams", Required = global::Newtonsoft.Json.Required.Always)]
        public int? MaxTeams { get; set; } = default!;

        /// <summary>
        /// The maximum allowable members per team.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("max_members", Required = global::Newtonsoft.Json.Required.Always)]
        public int? MaxMembers { get; set; } = default!;

        /// <summary>
        /// The selected editor for the assignment.<br/>
        /// Example: codespaces
        /// </summary>
        /// <example>codespaces</example>
        [global::Newtonsoft.Json.JsonProperty("editor", Required = global::Newtonsoft.Json.Required.Always)]
        public string Editor { get; set; } = default!;

        /// <summary>
        /// The number of students that have accepted the assignment.<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::Newtonsoft.Json.JsonProperty("accepted", Required = global::Newtonsoft.Json.Required.Always)]
        public int Accepted { get; set; } = default!;

        /// <summary>
        /// The number of students that have submitted the assignment.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("submitted", Required = global::Newtonsoft.Json.Required.Always)]
        public int Submitted { get; set; } = default!;

        /// <summary>
        /// The number of students that have passed the assignment.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("passing", Required = global::Newtonsoft.Json.Required.Always)]
        public int Passing { get; set; } = default!;

        /// <summary>
        /// The programming language used in the assignment.<br/>
        /// Example: elixir
        /// </summary>
        /// <example>elixir</example>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// The time at which the assignment is due.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deadline", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? Deadline { get; set; } = default!;

        /// <summary>
        /// A GitHub repository view for Classroom
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starter_code_repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleClassroomRepository StarterCodeRepository { get; set; } = default!;

        /// <summary>
        /// A GitHub Classroom classroom
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classroom", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Classroom Classroom { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassroomAssignment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the repository.<br/>
        /// Example: 42
        /// </param>
        /// <param name="publicRepo">
        /// Whether an accepted assignment creates a public repository.<br/>
        /// Example: true
        /// </param>
        /// <param name="title">
        /// Assignment title.<br/>
        /// Example: Intro to Binaries
        /// </param>
        /// <param name="type">
        /// Whether it's a group assignment or individual assignment.<br/>
        /// Example: individual
        /// </param>
        /// <param name="inviteLink">
        /// The link that a student can use to accept the assignment.<br/>
        /// Example: https://classroom.github.com/a/Lx7jiUgx
        /// </param>
        /// <param name="invitationsEnabled">
        /// Whether the invitation link is enabled. Visiting an enabled invitation link will accept the assignment.<br/>
        /// Example: true
        /// </param>
        /// <param name="slug">
        /// Sluggified name of the assignment.<br/>
        /// Example: intro-to-binaries
        /// </param>
        /// <param name="studentsAreRepoAdmins">
        /// Whether students are admins on created repository when a student accepts the assignment.<br/>
        /// Example: true
        /// </param>
        /// <param name="feedbackPullRequestsEnabled">
        /// Whether feedback pull request will be created when a student accepts the assignment.<br/>
        /// Example: true
        /// </param>
        /// <param name="maxTeams">
        /// The maximum allowable teams for the assignment.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxMembers">
        /// The maximum allowable members per team.<br/>
        /// Example: 0
        /// </param>
        /// <param name="editor">
        /// The selected editor for the assignment.<br/>
        /// Example: codespaces
        /// </param>
        /// <param name="accepted">
        /// The number of students that have accepted the assignment.<br/>
        /// Example: 25
        /// </param>
        /// <param name="submitted">
        /// The number of students that have submitted the assignment.<br/>
        /// Example: 10
        /// </param>
        /// <param name="passing">
        /// The number of students that have passed the assignment.<br/>
        /// Example: 10
        /// </param>
        /// <param name="language">
        /// The programming language used in the assignment.<br/>
        /// Example: elixir
        /// </param>
        /// <param name="deadline">
        /// The time at which the assignment is due.
        /// </param>
        /// <param name="starterCodeRepository">
        /// A GitHub repository view for Classroom
        /// </param>
        /// <param name="classroom">
        /// A GitHub Classroom classroom
        /// </param>
        public ClassroomAssignment(
            int id,
            bool publicRepo,
            string title,
            global::G.ClassroomAssignmentType type,
            string inviteLink,
            bool invitationsEnabled,
            string slug,
            bool studentsAreRepoAdmins,
            bool feedbackPullRequestsEnabled,
            int? maxTeams,
            int? maxMembers,
            string editor,
            int accepted,
            int submitted,
            int passing,
            string language,
            global::System.DateTime? deadline,
            global::G.SimpleClassroomRepository starterCodeRepository,
            global::G.Classroom classroom)
        {
            this.Id = id;
            this.PublicRepo = publicRepo;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type;
            this.InviteLink = inviteLink ?? throw new global::System.ArgumentNullException(nameof(inviteLink));
            this.InvitationsEnabled = invitationsEnabled;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.StudentsAreRepoAdmins = studentsAreRepoAdmins;
            this.FeedbackPullRequestsEnabled = feedbackPullRequestsEnabled;
            this.MaxTeams = maxTeams;
            this.MaxMembers = maxMembers;
            this.Editor = editor ?? throw new global::System.ArgumentNullException(nameof(editor));
            this.Accepted = accepted;
            this.Submitted = submitted;
            this.Passing = passing;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Deadline = deadline;
            this.StarterCodeRepository = starterCodeRepository ?? throw new global::System.ArgumentNullException(nameof(starterCodeRepository));
            this.Classroom = classroom ?? throw new global::System.ArgumentNullException(nameof(classroom));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassroomAssignment" /> class.
        /// </summary>
        public ClassroomAssignment()
        {
        }
    }
}