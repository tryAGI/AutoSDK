//HintName: G.Models.Assets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The assets of the generation
    /// </summary>
    public sealed partial class Assets
    {
        /// <summary>
        /// The URL of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public string? Video { get; set; }

        /// <summary>
        /// The URL of the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Assets" /> class.
        /// </summary>
        /// <param name="video">
        /// The URL of the video
        /// </param>
        /// <param name="image">
        /// The URL of the image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Assets(
            string? video,
            string? image)
        {
            this.Video = video;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Assets" /> class.
        /// </summary>
        public Assets()
        {
        }
    }
}