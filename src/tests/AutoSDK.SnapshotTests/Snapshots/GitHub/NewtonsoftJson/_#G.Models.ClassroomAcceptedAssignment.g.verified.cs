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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Whether an accepted assignment has been submitted.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("submitted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Submitted { get; set; } = default!;

        /// <summary>
        /// Whether a submission passed.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("passing", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Passing { get; set; } = default!;

        /// <summary>
        /// Count of student commits.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("commit_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CommitCount { get; set; } = default!;

        /// <summary>
        /// Most recent grade.<br/>
        /// Example: 10/10
        /// </summary>
        /// <example>10/10</example>
        [global::Newtonsoft.Json.JsonProperty("grade", Required = global::Newtonsoft.Json.Required.Always)]
        public string Grade { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("students", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SimpleClassroomUser> Students { get; set; } = default!;

        /// <summary>
        /// A GitHub repository view for Classroom
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleClassroomRepository Repository { get; set; } = default!;

        /// <summary>
        /// A GitHub Classroom assignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleClassroomAssignment Assignment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.ClassroomAcceptedAssignment? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ClassroomAcceptedAssignment>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ClassroomAcceptedAssignment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ClassroomAcceptedAssignment?>(serializer.Deserialize<global::G.ClassroomAcceptedAssignment>(jsonReader));
        }

    }
}