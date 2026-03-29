//HintName: G.Models.SharedUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resource creator
    /// </summary>
    public sealed partial class SharedUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("github_username")]
        public string? GithubUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// Profile image (640x640)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile_image")]
        public string? ProfileImage { get; set; }

        /// <summary>
        /// Profile image (90x90)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile_image_90")]
        public string? ProfileImage90 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedUser" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="twitterUsername"></param>
        /// <param name="githubUsername"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="profileImage">
        /// Profile image (640x640)
        /// </param>
        /// <param name="profileImage90">
        /// Profile image (90x90)
        /// </param>
        public SharedUser(
            string? name,
            string? username,
            string? twitterUsername,
            string? githubUsername,
            string? websiteUrl,
            string? profileImage,
            string? profileImage90)
        {
            this.Name = name;
            this.Username = username;
            this.TwitterUsername = twitterUsername;
            this.GithubUsername = githubUsername;
            this.WebsiteUrl = websiteUrl;
            this.ProfileImage = profileImage;
            this.ProfileImage90 = profileImage90;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedUser" /> class.
        /// </summary>
        public SharedUser()
        {
        }
    }
}