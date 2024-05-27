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
        /// An ID that identifies the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The user's login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// The user's display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// The type of user. Possible values are:  
        ///   
        /// * admin — Twitch administrator
        /// * global\_mod
        /// * staff — Twitch staff
        /// * "" — Normal user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public UserType Type { get; set; } = default!;

        /// <summary>
        /// The type of broadcaster. Possible values are:  
        ///   
        /// * affiliate — An [affiliate broadcaster](https://help.twitch.tv/s/article/joining-the-affiliate-program)
        /// * partner — A [partner broadcaster](https://help.twitch.tv/s/article/partner-program-overview)
        /// * "" — A normal broadcaster
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_type", Required = global::Newtonsoft.Json.Required.Always)]
        public UserBroadcasterType BroadcasterType { get; set; } = default!;

        /// <summary>
        /// The user's description of their channel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// A URL to the user's profile image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile_image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProfileImageUrl { get; set; } = default!;

        /// <summary>
        /// A URL to the user's offline image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offline_image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string OfflineImageUrl { get; set; } = default!;

        /// <summary>
        /// The number of times the user's channel has been viewed.  
        ///   
        /// **NOTE**: This field has been deprecated (see [Get Users API endpoint – "view\_count" deprecation](https://discuss.dev.twitch.tv/t/get-users-api-endpoint-view-count-deprecation/37777)). Any data in this field is not valid and should not be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("view_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ViewCount { get; set; } = default!;

        /// <summary>
        /// The user's verified email address. The object includes this field only if the user access token includes the **user:read:email** scope.  
        ///   
        /// If the request contains more than one user, only the user associated with the access token that provided consent will include an email address — the email address for all other users will be empty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The UTC date and time that the user's account was created. The timestamp is in RFC3339 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}