//HintName: G.Models.BackgroundImageInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundImageInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mobile_background_image")]
        public global::G.BackgroundImageDetail1? MobileBackgroundImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_background_image")]
        public global::G.BackgroundImageDetail1? WebBackgroundImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundImageInfo" /> class.
        /// </summary>
        /// <param name="mobileBackgroundImage"></param>
        /// <param name="webBackgroundImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundImageInfo(
            global::G.BackgroundImageDetail1? mobileBackgroundImage,
            global::G.BackgroundImageDetail1? webBackgroundImage)
        {
            this.MobileBackgroundImage = mobileBackgroundImage;
            this.WebBackgroundImage = webBackgroundImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundImageInfo" /> class.
        /// </summary>
        public BackgroundImageInfo()
        {
        }
    }
}