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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The id of the owner of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// The name of the avatar<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Whether the avatar is a greenscreen avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_greenscreen", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsGreenscreen { get; set; } = default!;

        /// <summary>
        /// The thumbnail url of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// The gender of the avatar
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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