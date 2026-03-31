//HintName: G.Models.GetAvatarByIdResponseVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class GetAvatarByIdResponseVariant12
    {
        /// <summary>
        /// The id of the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The id of the owner of the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// The name of the avatar<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the avatar is a greenscreen avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_greenscreen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsGreenscreen { get; set; }

        /// <summary>
        /// The thumbnail url of the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// The gender of the avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarByIdResponseVariant12" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the avatar
        /// </param>
        /// <param name="ownerId">
        /// The id of the owner of the avatar
        /// </param>
        /// <param name="name">
        /// The name of the avatar<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="isGreenscreen">
        /// Whether the avatar is a greenscreen avatar
        /// </param>
        /// <param name="thumbnailUrl">
        /// The thumbnail url of the avatar
        /// </param>
        /// <param name="gender">
        /// The gender of the avatar
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarByIdResponseVariant12(
            string id,
            string ownerId,
            string name,
            bool isGreenscreen,
            string? thumbnailUrl,
            string? gender)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsGreenscreen = isGreenscreen;
            this.ThumbnailUrl = thumbnailUrl;
            this.Gender = gender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarByIdResponseVariant12" /> class.
        /// </summary>
        public GetAvatarByIdResponseVariant12()
        {
        }
    }
}