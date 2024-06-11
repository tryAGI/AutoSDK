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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The user's login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// The user's display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The type of user. Possible values are:  
        ///   
        /// * admin — Twitch administrator
        /// * global\_mod
        /// * staff — Twitch staff
        /// * "" — Normal user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UserTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UserType Type { get; set; }

        /// <summary>
        /// The type of broadcaster. Possible values are:  
        ///   
        /// * affiliate — An [affiliate broadcaster](https://help.twitch.tv/s/article/joining-the-affiliate-program)
        /// * partner — A [partner broadcaster](https://help.twitch.tv/s/article/partner-program-overview)
        /// * "" — A normal broadcaster
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.UserBroadcasterTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UserBroadcasterType BroadcasterType { get; set; }

        /// <summary>
        /// The user's description of their channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// A URL to the user's profile image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileImageUrl { get; set; }

        /// <summary>
        /// A URL to the user's offline image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offline_image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OfflineImageUrl { get; set; }

        /// <summary>
        /// The number of times the user's channel has been viewed.  
        ///   
        /// **NOTE**: This field has been deprecated (see [Get Users API endpoint – "view\_count" deprecation](https://discuss.dev.twitch.tv/t/get-users-api-endpoint-view-count-deprecation/37777)). Any data in this field is not valid and should not be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ViewCount { get; set; }

        /// <summary>
        /// The user's verified email address. The object includes this field only if the user access token includes the **user:read:email** scope.  
        ///   
        /// If the request contains more than one user, only the user associated with the access token that provided consent will include an email address — the email address for all other users will be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The UTC date and time that the user's account was created. The timestamp is in RFC3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}