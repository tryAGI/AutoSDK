//HintName: G.Models.ClassroomAcceptedAssignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub Classroom accepted assignment
    /// </summary>
    public sealed partial class ClassroomAcceptedAssignment
    {
        /// <summary>
        /// Unique identifier of the repository.
        /// <br/>Example: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Whether an accepted assignment has been submitted.
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Submitted { get; set; }

        /// <summary>
        /// Whether a submission passed.
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passing { get; set; }

        /// <summary>
        /// Count of student commits.
        /// <br/>Example: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommitCount { get; set; }

        /// <summary>
        /// Most recent grade.
        /// <br/>Example: 10/10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grade")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Grade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("students")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<SimpleClassroomUser> Students { get; set; }

        /// <summary>
        /// A GitHub repository view for Classroom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SimpleClassroomRepository Repository { get; set; }

        /// <summary>
        /// A GitHub Classroom assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SimpleClassroomAssignment Assignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}