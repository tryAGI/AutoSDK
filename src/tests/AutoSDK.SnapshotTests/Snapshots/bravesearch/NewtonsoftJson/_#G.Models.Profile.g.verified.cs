//HintName: G.Models.Profile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Profile information for a content creator.
    /// </summary>
    public sealed partial class Profile
    {
        /// <summary>
        /// Name of the profile.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Full/long name of the profile.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("long_name")]
        public string? LongName { get; set; }

        /// <summary>
        /// URL to the profile page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// URL of the profile image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("img")]
        public string? Img { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the profile.
        /// </param>
        /// <param name="longName">
        /// Full/long name of the profile.
        /// </param>
        /// <param name="url">
        /// URL to the profile page.
        /// </param>
        /// <param name="img">
        /// URL of the profile image.
        /// </param>
        public Profile(
            string? name,
            string? longName,
            string? url,
            string? img)
        {
            this.Name = name;
            this.LongName = longName;
            this.Url = url;
            this.Img = img;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Profile" /> class.
        /// </summary>
        public Profile()
        {
        }
    }
}