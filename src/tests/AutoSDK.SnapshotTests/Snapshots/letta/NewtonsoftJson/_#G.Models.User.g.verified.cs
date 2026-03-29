//HintName: G.Models.User.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of a user.
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// The human-friendly ID of the User
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The creation date of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The update date of the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Whether this user is deleted or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the user.
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the User
        /// </param>
        /// <param name="createdAt">
        /// The creation date of the user.
        /// </param>
        /// <param name="updatedAt">
        /// The update date of the user.
        /// </param>
        /// <param name="isDeleted">
        /// Whether this user is deleted or not.<br/>
        /// Default Value: false
        /// </param>
        public User(
            string name,
            string? id,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            bool? isDeleted)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IsDeleted = isDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }
    }
}