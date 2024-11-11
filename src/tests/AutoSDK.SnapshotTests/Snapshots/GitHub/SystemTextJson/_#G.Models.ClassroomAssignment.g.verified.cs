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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Whether an accepted assignment creates a public repository.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PublicRepo { get; set; }

        /// <summary>
        /// Assignment title.<br/>
        /// Example: Intro to Binaries
        /// </summary>
        /// <example>Intro to Binaries</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Whether it's a group assignment or individual assignment.<br/>
        /// Example: individual
        /// </summary>
        /// <example>individual</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassroomAssignmentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ClassroomAssignmentType Type { get; set; }

        /// <summary>
        /// The link that a student can use to accept the assignment.<br/>
        /// Example: https://classroom.github.com/a/Lx7jiUgx
        /// </summary>
        /// <example>https://classroom.github.com/a/Lx7jiUgx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InviteLink { get; set; }

        /// <summary>
        /// Whether the invitation link is enabled. Visiting an enabled invitation link will accept the assignment.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitations_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InvitationsEnabled { get; set; }

        /// <summary>
        /// Sluggified name of the assignment.<br/>
        /// Example: intro-to-binaries
        /// </summary>
        /// <example>intro-to-binaries</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Whether students are admins on created repository when a student accepts the assignment.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("students_are_repo_admins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool StudentsAreRepoAdmins { get; set; }

        /// <summary>
        /// Whether feedback pull request will be created when a student accepts the assignment.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_pull_requests_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FeedbackPullRequestsEnabled { get; set; }

        /// <summary>
        /// The maximum allowable teams for the assignment.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? MaxTeams { get; set; }

        /// <summary>
        /// The maximum allowable members per team.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? MaxMembers { get; set; }

        /// <summary>
        /// The selected editor for the assignment.<br/>
        /// Example: codespaces
        /// </summary>
        /// <example>codespaces</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("editor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Editor { get; set; }

        /// <summary>
        /// The number of students that have accepted the assignment.<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Accepted { get; set; }

        /// <summary>
        /// The number of students that have submitted the assignment.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Submitted { get; set; }

        /// <summary>
        /// The number of students that have passed the assignment.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("passing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Passing { get; set; }

        /// <summary>
        /// The programming language used in the assignment.<br/>
        /// Example: elixir
        /// </summary>
        /// <example>elixir</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The time at which the assignment is due.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deadline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? Deadline { get; set; }

        /// <summary>
        /// A GitHub repository view for Classroom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starter_code_repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleClassroomRepository StarterCodeRepository { get; set; }

        /// <summary>
        /// A GitHub Classroom classroom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classroom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Classroom Classroom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
        public static global::G.ClassroomAssignment? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ClassroomAssignment),
                jsonSerializerContext) as global::G.ClassroomAssignment;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ClassroomAssignment? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ClassroomAssignment>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ClassroomAssignment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ClassroomAssignment),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ClassroomAssignment;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ClassroomAssignment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ClassroomAssignment?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}