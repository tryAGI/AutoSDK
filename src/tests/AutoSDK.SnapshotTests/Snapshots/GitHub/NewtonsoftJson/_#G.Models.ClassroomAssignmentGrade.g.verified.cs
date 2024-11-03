//HintName: G.Models.ClassroomAssignmentGrade.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Grade for a student or groups GitHub Classroom assignment
    /// </summary>
    public sealed partial class ClassroomAssignmentGrade
    {
        /// <summary>
        /// Name of the assignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssignmentName { get; set; } = default!;

        /// <summary>
        /// URL of the assignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssignmentUrl { get; set; } = default!;

        /// <summary>
        /// URL of the starter code for the assignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starter_code_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StarterCodeUrl { get; set; } = default!;

        /// <summary>
        /// GitHub username of the student
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_username", Required = global::Newtonsoft.Json.Required.Always)]
        public string GithubUsername { get; set; } = default!;

        /// <summary>
        /// Roster identifier of the student
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roster_identifier", Required = global::Newtonsoft.Json.Required.Always)]
        public string RosterIdentifier { get; set; } = default!;

        /// <summary>
        /// Name of the student's assignment repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("student_repository_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string StudentRepositoryName { get; set; } = default!;

        /// <summary>
        /// URL of the student's assignment repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("student_repository_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StudentRepositoryUrl { get; set; } = default!;

        /// <summary>
        /// Timestamp of the student's assignment submission
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("submission_timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubmissionTimestamp { get; set; } = default!;

        /// <summary>
        /// Number of points awarded to the student
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points_awarded", Required = global::Newtonsoft.Json.Required.Always)]
        public int PointsAwarded { get; set; } = default!;

        /// <summary>
        /// Number of points available for the assignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points_available", Required = global::Newtonsoft.Json.Required.Always)]
        public int PointsAvailable { get; set; } = default!;

        /// <summary>
        /// If a group assignment, name of the group the student is in
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_name")]
        public string? GroupName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.ClassroomAssignmentGrade? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ClassroomAssignmentGrade>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ClassroomAssignmentGrade?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ClassroomAssignmentGrade?>(serializer.Deserialize<global::G.ClassroomAssignmentGrade>(jsonReader));
        }

    }
}