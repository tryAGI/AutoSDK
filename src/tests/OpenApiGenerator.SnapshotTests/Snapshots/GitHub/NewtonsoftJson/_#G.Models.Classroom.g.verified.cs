//HintName: G.Models.Classroom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub Classroom classroom
    /// </summary>
    public sealed partial class Classroom
    {
        /// <summary>
        /// Unique identifier of the classroom.<br/>
        /// Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the classroom.<br/>
        /// Example: Programming Elixir
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Whether classroom is archived.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Archived { get; set; } = default!;

        /// <summary>
        /// A GitHub organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleClassroomOrganization? Organization { get; set; } = default!;

        /// <summary>
        /// The URL of the classroom on GitHub Classroom.<br/>
        /// Example: https://classroom.github.com/classrooms/1-programming-elixir
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}