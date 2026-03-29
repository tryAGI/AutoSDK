//HintName: G.Models.ImportProjectMediaRequestAddCompositionClip.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportProjectMediaRequestAddCompositionClip
    {
        /// <summary>
        /// Media reference ID (display name) of the media to add as a clip<br/>
        /// Example: Misc/intro.mp4
        /// </summary>
        /// <example>Misc/intro.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Media { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddCompositionClip" /> class.
        /// </summary>
        /// <param name="media">
        /// Media reference ID (display name) of the media to add as a clip<br/>
        /// Example: Misc/intro.mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportProjectMediaRequestAddCompositionClip(
            string media)
        {
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddCompositionClip" /> class.
        /// </summary>
        public ImportProjectMediaRequestAddCompositionClip()
        {
        }
    }
}