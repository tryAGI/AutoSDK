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
        /// Initializes a new instance of the <see cref="ClassroomAssignmentGrade" /> class.
        /// </summary>
        /// <param name="assignmentName">
        /// Name of the assignment
        /// </param>
        /// <param name="assignmentUrl">
        /// URL of the assignment
        /// </param>
        /// <param name="starterCodeUrl">
        /// URL of the starter code for the assignment
        /// </param>
        /// <param name="githubUsername">
        /// GitHub username of the student
        /// </param>
        /// <param name="rosterIdentifier">
        /// Roster identifier of the student
        /// </param>
        /// <param name="studentRepositoryName">
        /// Name of the student's assignment repository
        /// </param>
        /// <param name="studentRepositoryUrl">
        /// URL of the student's assignment repository
        /// </param>
        /// <param name="submissionTimestamp">
        /// Timestamp of the student's assignment submission
        /// </param>
        /// <param name="pointsAwarded">
        /// Number of points awarded to the student
        /// </param>
        /// <param name="pointsAvailable">
        /// Number of points available for the assignment
        /// </param>
        /// <param name="groupName">
        /// If a group assignment, name of the group the student is in
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassroomAssignmentGrade(
            string assignmentName,
            string assignmentUrl,
            string starterCodeUrl,
            string githubUsername,
            string rosterIdentifier,
            string studentRepositoryName,
            string studentRepositoryUrl,
            string submissionTimestamp,
            int pointsAwarded,
            int pointsAvailable,
            string? groupName)
        {
            this.AssignmentName = assignmentName ?? throw new global::System.ArgumentNullException(nameof(assignmentName));
            this.AssignmentUrl = assignmentUrl ?? throw new global::System.ArgumentNullException(nameof(assignmentUrl));
            this.StarterCodeUrl = starterCodeUrl ?? throw new global::System.ArgumentNullException(nameof(starterCodeUrl));
            this.GithubUsername = githubUsername ?? throw new global::System.ArgumentNullException(nameof(githubUsername));
            this.RosterIdentifier = rosterIdentifier ?? throw new global::System.ArgumentNullException(nameof(rosterIdentifier));
            this.StudentRepositoryName = studentRepositoryName ?? throw new global::System.ArgumentNullException(nameof(studentRepositoryName));
            this.StudentRepositoryUrl = studentRepositoryUrl ?? throw new global::System.ArgumentNullException(nameof(studentRepositoryUrl));
            this.SubmissionTimestamp = submissionTimestamp ?? throw new global::System.ArgumentNullException(nameof(submissionTimestamp));
            this.PointsAwarded = pointsAwarded;
            this.PointsAvailable = pointsAvailable;
            this.GroupName = groupName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassroomAssignmentGrade" /> class.
        /// </summary>
        public ClassroomAssignmentGrade()
        {
        }
    }
}