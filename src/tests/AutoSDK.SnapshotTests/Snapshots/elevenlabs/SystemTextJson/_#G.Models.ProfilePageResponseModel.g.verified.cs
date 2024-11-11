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
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Handle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfilePicture { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePageResponseModel" /> class.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="publicUserId"></param>
        /// <param name="name"></param>
        /// <param name="bio"></param>
        /// <param name="profilePicture"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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