//HintName: G.Models.ProfilePageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProfilePageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("handle", Required = global::Newtonsoft.Json.Required.Always)]
        public string Handle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicUserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bio", Required = global::Newtonsoft.Json.Required.Always)]
        public string Bio { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile_picture", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProfilePicture { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePageResponseModel" /> class.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="publicUserId"></param>
        /// <param name="name"></param>
        /// <param name="bio"></param>
        /// <param name="profilePicture"></param>
        public ProfilePageResponseModel(
            string handle,
            string publicUserId,
            string name,
            string bio,
            string profilePicture)
        {
            this.Handle = handle ?? throw new global::System.ArgumentNullException(nameof(handle));
            this.PublicUserId = publicUserId ?? throw new global::System.ArgumentNullException(nameof(publicUserId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Bio = bio ?? throw new global::System.ArgumentNullException(nameof(bio));
            this.ProfilePicture = profilePicture ?? throw new global::System.ArgumentNullException(nameof(profilePicture));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePageResponseModel" /> class.
        /// </summary>
        public ProfilePageResponseModel()
        {
        }
    }
}