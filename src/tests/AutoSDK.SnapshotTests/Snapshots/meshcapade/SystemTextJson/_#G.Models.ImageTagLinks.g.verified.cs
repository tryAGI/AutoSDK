//HintName: G.Models.ImageTagLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageTagLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_avatar_texture")]
        public string? FullAvatarTexture { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTagLinks" /> class.
        /// </summary>
        /// <param name="fullAvatarTexture"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageTagLinks(
            string? fullAvatarTexture)
        {
            this.FullAvatarTexture = fullAvatarTexture;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTagLinks" /> class.
        /// </summary>
        public ImageTagLinks()
        {
        }
    }
}