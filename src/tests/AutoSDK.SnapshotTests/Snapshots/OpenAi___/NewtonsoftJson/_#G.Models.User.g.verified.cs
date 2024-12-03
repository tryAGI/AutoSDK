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
        public global::System.DateTimeOffset AddedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `organization.user`
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="name">
        /// The name of the user
        /// </param>
        /// <param name="email">
        /// The email address of the user
        /// </param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="addedAt">
        /// The Unix timestamp (in seconds) of when the user was added.
        /// </param>
        public User(
            string id,
            string name,
            string email,
            global::G.UserRole role,
            global::System.DateTimeOffset addedAt,
            global::G.UserObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
            this.AddedAt = addedAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }
    }
}