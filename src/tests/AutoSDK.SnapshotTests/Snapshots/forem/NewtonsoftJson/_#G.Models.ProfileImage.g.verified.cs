//HintName: G.Models.ProfileImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A profile image object
    /// </summary>
    public sealed partial class ProfileImage
    {
        /// <summary>
        /// Return profile_image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type_of")]
        public string? TypeOf { get; set; }

        /// <summary>
        /// Determines the type of the profile image owner (user or organization)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_of")]
        public string? ImageOf { get; set; }

        /// <summary>
        /// Profile image (640x640)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile_image")]
        public string? ProfileImage1 { get; set; }

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
        /// Initializes a new instance of the <see cref="ProfileImage" /> class.
        /// </summary>
        /// <param name="typeOf">
        /// Return profile_image
        /// </param>
        /// <param name="imageOf">
        /// Determines the type of the profile image owner (user or organization)
        /// </param>
        /// <param name="profileImage1">
        /// Profile image (640x640)
        /// </param>
        /// <param name="profileImage90">
        /// Profile image (90x90)
        /// </param>
        public ProfileImage(
            string? typeOf,
            string? imageOf,
            string? profileImage1,
            string? profileImage90)
        {
            this.TypeOf = typeOf;
            this.ImageOf = imageOf;
            this.ProfileImage1 = profileImage1;
            this.ProfileImage90 = profileImage90;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileImage" /> class.
        /// </summary>
        public ProfileImage()
        {
        }
    }
}