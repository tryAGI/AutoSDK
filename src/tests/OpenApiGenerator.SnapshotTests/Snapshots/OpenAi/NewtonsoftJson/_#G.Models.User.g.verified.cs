//HintName: G.Models.User.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual `user` within an organization.
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// The object type, which is always `organization.user`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.UserObject Object { get; set; }

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
        /// `owner` or `reader`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UserRole Role { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the user was added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("added_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int AddedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}