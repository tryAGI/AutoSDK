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
        [global::System.Text.Json.Serialization.JsonPropertyName("assignment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssignmentName { get; set; }

        /// <summary>
        /// URL of the assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssignmentUrl { get; set; }

        /// <summary>
        /// URL of the starter code for the assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starter_code_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StarterCodeUrl { get; set; }

        /// <summary>
        /// GitHub username of the student
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GithubUsername { get; set; }

        /// <summary>
        /// Roster identifier of the student
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roster_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RosterIdentifier { get; set; }

        /// <summary>
        /// Name of the student's assignment repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("student_repository_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StudentRepositoryName { get; set; }

        /// <summary>
        /// URL of the student's assignment repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("student_repository_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StudentRepositoryUrl { get; set; }

        /// <summary>
        /// Timestamp of the student's assignment submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submission_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubmissionTimestamp { get; set; }

        /// <summary>
        /// Number of points awarded to the student
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points_awarded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PointsAwarded { get; set; }

        /// <summary>
        /// Number of points available for the assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PointsAvailable { get; set; }

        /// <summary>
        /// If a group assignment, name of the group the student is in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string? GroupName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
    #if NET6_0_OR_GREATER
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
        public static global::G.ClassroomAssignmentGrade? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ClassroomAssignmentGrade),
                jsonSerializerContext) as global::G.ClassroomAssignmentGrade;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ClassroomAssignmentGrade? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ClassroomAssignmentGrade>(
                json,
                jsonSerializerOptions);
        }

    }
}