//HintName: G.Models.UserProfile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UserProfile describes the public data of a user.
    /// </summary>
    public sealed partial class UserProfile
    {
        /// <summary>
        /// Display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Biography.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bio")]
        public string? Bio { get; set; }

        /// <summary>
        /// Avatar in base64 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Public email.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicEmail")]
        public string? PublicEmail { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// Social profile links list the links to the user's social profiles.<br/>
        /// The key represents the provider, and the value is the corresponding URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("socialProfileLinks")]
        public global::System.Collections.Generic.Dictionary<string, string>? SocialProfileLinks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Display name.
        /// </param>
        /// <param name="bio">
        /// Biography.
        /// </param>
        /// <param name="avatar">
        /// Avatar in base64 format.
        /// </param>
        /// <param name="publicEmail">
        /// Public email.
        /// </param>
        /// <param name="companyName">
        /// Company name.
        /// </param>
        /// <param name="socialProfileLinks">
        /// Social profile links list the links to the user's social profiles.<br/>
        /// The key represents the provider, and the value is the corresponding URL.
        /// </param>
        public UserProfile(
            string? displayName,
            string? bio,
            string? avatar,
            string? publicEmail,
            string? companyName,
            global::System.Collections.Generic.Dictionary<string, string>? socialProfileLinks)
        {
            this.DisplayName = displayName;
            this.Bio = bio;
            this.Avatar = avatar;
            this.PublicEmail = publicEmail;
            this.CompanyName = companyName;
            this.SocialProfileLinks = socialProfileLinks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        public UserProfile()
        {
        }
    }
}