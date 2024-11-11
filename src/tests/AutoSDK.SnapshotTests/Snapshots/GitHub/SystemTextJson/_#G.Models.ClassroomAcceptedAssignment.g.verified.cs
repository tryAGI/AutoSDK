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
        /// Unique identifier of the repository.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Whether an accepted assignment has been submitted.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Submitted { get; set; }

        /// <summary>
        /// Whether a submission passed.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("passing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passing { get; set; }

        /// <summary>
        /// Count of student commits.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommitCount { get; set; }

        /// <summary>
        /// Most recent grade.<br/>
        /// Example: 10/10
        /// </summary>
        /// <example>10/10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grade")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Grade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("students")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SimpleClassroomUser> Students { get; set; }

        /// <summary>
        /// A GitHub repository view for Classroom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleClassroomRepository Repository { get; set; }

        /// <summary>
        /// A GitHub Classroom assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleClassroomAssignment Assignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassroomAcceptedAssignment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the repository.<br/>
        /// Example: 42
        /// </param>
        /// <param name="submitted">
        /// Whether an accepted assignment has been submitted.<br/>
        /// Example: true
        /// </param>
        /// <param name="passing">
        /// Whether a submission passed.<br/>
        /// Example: true
        /// </param>
        /// <param name="commitCount">
        /// Count of student commits.<br/>
        /// Example: 5
        /// </param>
        /// <param name="grade">
        /// Most recent grade.<br/>
        /// Example: 10/10
        /// </param>
        /// <param name="students"></param>
        /// <param name="repository">
        /// A GitHub repository view for Classroom
        /// </param>
        /// <param name="assignment">
        /// A GitHub Classroom assignment
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ClassroomAcceptedAssignment(
            int id,
            bool submitted,
            bool passing,
            int commitCount,
            string grade,
            global::System.Collections.Generic.IList<global::G.SimpleClassroomUser> students,
            global::G.SimpleClassroomRepository repository,
            global::G.SimpleClassroomAssignment assignment)
        {
            this.Id = id;
            this.Submitted = submitted;
            this.Passing = passing;
            this.CommitCount = commitCount;
            this.Grade = grade ?? throw new global::System.ArgumentNullException(nameof(grade));
            this.Students = students ?? throw new global::System.ArgumentNullException(nameof(students));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Assignment = assignment ?? throw new global::System.ArgumentNullException(nameof(assignment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassroomAcceptedAssignment" /> class.
        /// </summary>
        public ClassroomAcceptedAssignment()
        {
        }
    }
}