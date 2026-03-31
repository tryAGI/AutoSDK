//HintName: G.Models.GetClipsResponseClipConfigLogo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClipsResponseClipConfigLogo
    {
        /// <summary>
        /// https url to an ARGB jpg/png image, a default logo is used otherwise
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// position of the logo in pixels from the top left corner (w,h) negative values are subtracted from last pixel<br/>
        /// Example: [0, 500]
        /// </summary>
        /// <example>[0, 500]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsResponseClipConfigLogo" /> class.
        /// </summary>
        /// <param name="url">
        /// https url to an ARGB jpg/png image, a default logo is used otherwise
        /// </param>
        /// <param name="position">
        /// position of the logo in pixels from the top left corner (w,h) negative values are subtracted from last pixel<br/>
        /// Example: [0, 500]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetClipsResponseClipConfigLogo(
            string url,
            global::System.Collections.Generic.IList<int> position)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsResponseClipConfigLogo" /> class.
        /// </summary>
        public GetClipsResponseClipConfigLogo()
        {
        }
    }
}