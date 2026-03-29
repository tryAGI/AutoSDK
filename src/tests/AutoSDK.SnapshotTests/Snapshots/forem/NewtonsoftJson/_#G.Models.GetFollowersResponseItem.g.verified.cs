//HintName: G.Models.GetFollowersResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A follower
    /// </summary>
    public sealed partial class GetFollowersResponseItem
    {
        /// <summary>
        /// user_follower by default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type_of")]
        public string? TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The follower's user id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// The follower's name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A path to the follower's profile
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Profile image (640x640)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile_image")]
        public string? ProfileImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFollowersResponseItem" /> class.
        /// </summary>
        /// <param name="typeOf">
        /// user_follower by default
        /// </param>
        /// <param name="id"></param>
        /// <param name="userId">
        /// The follower's user id
        /// </param>
        /// <param name="name">
        /// The follower's name
        /// </param>
        /// <param name="path">
        /// A path to the follower's profile
        /// </param>
        /// <param name="profileImage">
        /// Profile image (640x640)
        /// </param>
        public GetFollowersResponseItem(
            string? typeOf,
            int? id,
            int? userId,
            string? name,
            string? path,
            string? profileImage)
        {
            this.TypeOf = typeOf;
            this.Id = id;
            this.UserId = userId;
            this.Name = name;
            this.Path = path;
            this.ProfileImage = profileImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFollowersResponseItem" /> class.
        /// </summary>
        public GetFollowersResponseItem()
        {
        }
    }
}