//HintName: G.Models.UserPublicGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class UserPublicGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_colour")]
        public string? AvatarColour { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPublicGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="createdAt"></param>
        /// <param name="avatarColour"></param>
        public UserPublicGet(
            string id,
            string username,
            global::System.DateTime createdAt,
            string? avatarColour)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.CreatedAt = createdAt;
            this.AvatarColour = avatarColour;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPublicGet" /> class.
        /// </summary>
        public UserPublicGet()
        {
        }
    }
}