//HintName: G.Models.SimpleClassroom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub Classroom classroom
    /// </summary>
    public sealed partial class SimpleClassroom
    {
        /// <summary>
        /// Unique identifier of the classroom.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the classroom.<br/>
        /// Example: Programming Elixir
        /// </summary>
        /// <example>Programming Elixir</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Returns whether classroom is archived or not.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("archived", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Archived { get; set; } = default!;

        /// <summary>
        /// The url of the classroom on GitHub Classroom.<br/>
        /// Example: https://classroom.github.com/classrooms/1-programming-elixir
        /// </summary>
        /// <example>https://classroom.github.com/classrooms/1-programming-elixir</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleClassroom" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the classroom.<br/>
        /// Example: 42
        /// </param>
        /// <param name="name">
        /// The name of the classroom.<br/>
        /// Example: Programming Elixir
        /// </param>
        /// <param name="archived">
        /// Returns whether classroom is archived or not.<br/>
        /// Example: false
        /// </param>
        /// <param name="url">
        /// The url of the classroom on GitHub Classroom.<br/>
        /// Example: https://classroom.github.com/classrooms/1-programming-elixir
        /// </param>
        public SimpleClassroom(
            int id,
            string name,
            bool archived,
            string url)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Archived = archived;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleClassroom" /> class.
        /// </summary>
        public SimpleClassroom()
        {
        }
    }
}