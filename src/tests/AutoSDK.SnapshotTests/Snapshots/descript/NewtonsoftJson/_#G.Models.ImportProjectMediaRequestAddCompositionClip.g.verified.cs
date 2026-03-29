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
        [global::Newtonsoft.Json.JsonProperty("media", Required = global::Newtonsoft.Json.Required.Always)]
        public string Media { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportProjectMediaRequestAddCompositionClip" /> class.
        /// </summary>
        /// <param name="media">
        /// Media reference ID (display name) of the media to add as a clip<br/>
        /// Example: Misc/intro.mp4
        /// </param>
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