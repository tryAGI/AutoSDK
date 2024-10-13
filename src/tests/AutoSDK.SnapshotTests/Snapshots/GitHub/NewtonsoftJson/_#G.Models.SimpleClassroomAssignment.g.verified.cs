//HintName: G.Models.SimpleClassroomAssignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub Classroom assignment
    /// </summary>
    public sealed partial class SimpleClassroomAssignment
    {
        /// <summary>
        /// Unique identifier of the repository.<br/>
        /// Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Whether an accepted assignment creates a public repository.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_repo", Required = global::Newtonsoft.Json.Required.Always)]
        public bool PublicRepo { get; set; } = default!;

        /// <summary>
        /// Assignment title.<br/>
        /// Example: Intro to Binaries
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Whether it's a Group Assignment or Individual Assignment.<br/>
        /// Example: individual
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleClassroomAssignmentType Type { get; set; } = default!;

        /// <summary>
        /// The link that a student can use to accept the assignment.<br/>
        /// Example: https://classroom.github.com/a/Lx7jiUgx
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invite_link", Required = global::Newtonsoft.Json.Required.Always)]
        public string InviteLink { get; set; } = default!;

        /// <summary>
        /// Whether the invitation link is enabled. Visiting an enabled invitation link will accept the assignment.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitations_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool InvitationsEnabled { get; set; } = default!;

        /// <summary>
        /// Sluggified name of the assignment.<br/>
        /// Example: intro-to-binaries
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Whether students are admins on created repository on accepted assignment.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("students_are_repo_admins", Required = global::Newtonsoft.Json.Required.Always)]
        public bool StudentsAreRepoAdmins { get; set; } = default!;

        /// <summary>
        /// Whether feedback pull request will be created on assignment acceptance.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_pull_requests_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool FeedbackPullRequestsEnabled { get; set; } = default!;

        /// <summary>
        /// The maximum allowable teams for the assignment.<br/>
        /// Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_teams")]
        public int? MaxTeams { get; set; }

        /// <summary>
        /// The maximum allowable members per team.<br/>
        /// Example: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_members")]
        public int? MaxMembers { get; set; }

        /// <summary>
        /// The selected editor for the assignment.<br/>
        /// Example: codespaces
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("editor", Required = global::Newtonsoft.Json.Required.Always)]
        public string Editor { get; set; } = default!;

        /// <summary>
        /// The number of students that have accepted the assignment.<br/>
        /// Example: 25
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accepted", Required = global::Newtonsoft.Json.Required.Always)]
        public int Accepted { get; set; } = default!;

        /// <summary>
        /// The number of students that have submitted the assignment.<br/>
        /// Example: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("submitted", Required = global::Newtonsoft.Json.Required.Always)]
        public int Submitted { get; set; } = default!;

        /// <summary>
        /// The number of students that have passed the assignment.<br/>
        /// Example: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passing", Required = global::Newtonsoft.Json.Required.Always)]
        public int Passing { get; set; } = default!;

        /// <summary>
        /// The programming language used in the assignment.<br/>
        /// Example: elixir
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// The time at which the assignment is due.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deadline", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? Deadline { get; set; } = default!;

        /// <summary>
        /// A GitHub Classroom classroom
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classroom", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleClassroom Classroom { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
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
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.SimpleClassroomAssignment? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SimpleClassroomAssignment>(
                json,
                jsonSerializerOptions);
        }

    }
}