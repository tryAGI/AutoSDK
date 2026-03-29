//HintName: G.Models.BackgroundImageInfo1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundImageInfo1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mobile_background_image")]
        public global::G.BackgroundImageDetail? MobileBackgroundImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_background_image")]
        public global::G.BackgroundImageDetail? WebBackgroundImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundImageInfo1" /> class.
        /// </summary>
        /// <param name="mobileBackgroundImage"></param>
        /// <param name="webBackgroundImage"></param>
        public BackgroundImageInfo1(
            global::G.BackgroundImageDetail? mobileBackgroundImage,
            global::G.BackgroundImageDetail? webBackgroundImage)
        {
            this.MobileBackgroundImage = mobileBackgroundImage;
            this.WebBackgroundImage = webBackgroundImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundImageInfo1" /> class.
        /// </summary>
        public BackgroundImageInfo1()
        {
        }
    }
}