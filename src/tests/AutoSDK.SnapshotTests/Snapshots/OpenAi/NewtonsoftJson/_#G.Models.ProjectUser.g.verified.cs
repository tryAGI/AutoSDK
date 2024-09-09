//HintName: G.Models.ProjectUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual user in a project.
    /// </summary>
    public sealed partial class ProjectUser
    {
        /// <summary>
        /// The object type, which is always `organization.project.user`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ProjectUserObject Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The email address of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// `owner` or `member`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectUserRole Role { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the project was added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("added_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset AddedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}