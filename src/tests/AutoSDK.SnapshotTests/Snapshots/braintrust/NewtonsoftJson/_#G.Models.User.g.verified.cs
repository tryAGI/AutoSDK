//HintName: G.Models.User.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Given name of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("given_name")]
        public string? GivenName { get; set; }

        /// <summary>
        /// Family name of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("family_name")]
        public string? FamilyName { get; set; }

        /// <summary>
        /// The user's email
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// URL of the user's Avatar image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// Date of user creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the user
        /// </param>
        /// <param name="givenName">
        /// Given name of the user
        /// </param>
        /// <param name="familyName">
        /// Family name of the user
        /// </param>
        /// <param name="email">
        /// The user's email
        /// </param>
        /// <param name="avatarUrl">
        /// URL of the user's Avatar image
        /// </param>
        /// <param name="created">
        /// Date of user creation
        /// </param>
        public User(
            global::System.Guid id,
            string? givenName,
            string? familyName,
            string? email,
            string? avatarUrl,
            global::System.DateTime? created)
        {
            this.Id = id;
            this.GivenName = givenName;
            this.FamilyName = familyName;
            this.Email = email;
            this.AvatarUrl = avatarUrl;
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }
    }
}