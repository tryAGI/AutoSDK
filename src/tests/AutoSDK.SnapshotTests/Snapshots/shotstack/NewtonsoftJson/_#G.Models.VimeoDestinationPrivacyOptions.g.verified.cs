//HintName: G.Models.VimeoDestinationPrivacyOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options to control the visibility of videos and privacy features.
    /// </summary>
    public sealed partial class VimeoDestinationPrivacyOptions
    {
        /// <summary>
        /// Set who can view the videos. Available options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`anybody` - Anyone can view the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`nobody` - Only the video owner can view the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`contacts` - Only contacts can view the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`password` - A password is required to view the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`unlisted` - The video is not listed on Vimeo.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("view")]
        public global::G.VimeoDestinationPrivacyOptionsView? View { get; set; }

        /// <summary>
        /// Set who can embed the video. Available options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`public` - Anyone can embed the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`private` - Only the video owner can embed the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`whitelist` - Only whitelisted domains can embed the video.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed")]
        public global::G.VimeoDestinationPrivacyOptionsEmbed? Embed { get; set; }

        /// <summary>
        /// Set who can comment on the video. Available options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`anybody` - Anyone can comment on the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`nobody` - Only the video owner can comment on the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`contacts` - Only contacts can comment on the video.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments")]
        public global::G.VimeoDestinationPrivacyOptionsComments? Comments { get; set; }

        /// <summary>
        /// Set whether the video can be downloaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download")]
        public bool? Download { get; set; }

        /// <summary>
        /// Set whether other users can add the video to their collections.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add")]
        public bool? Add { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VimeoDestinationPrivacyOptions" /> class.
        /// </summary>
        /// <param name="view">
        /// Set who can view the videos. Available options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`anybody` - Anyone can view the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`nobody` - Only the video owner can view the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`contacts` - Only contacts can view the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`password` - A password is required to view the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`unlisted` - The video is not listed on Vimeo.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="embed">
        /// Set who can embed the video. Available options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`public` - Anyone can embed the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`private` - Only the video owner can embed the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`whitelist` - Only whitelisted domains can embed the video.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="comments">
        /// Set who can comment on the video. Available options are: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`anybody` - Anyone can comment on the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`nobody` - Only the video owner can comment on the video.&lt;/li&gt;<br/>
        ///   &lt;li&gt;`contacts` - Only contacts can comment on the video.&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="download">
        /// Set whether the video can be downloaded.
        /// </param>
        /// <param name="add">
        /// Set whether other users can add the video to their collections.
        /// </param>
        public VimeoDestinationPrivacyOptions(
            global::G.VimeoDestinationPrivacyOptionsView? view,
            global::G.VimeoDestinationPrivacyOptionsEmbed? embed,
            global::G.VimeoDestinationPrivacyOptionsComments? comments,
            bool? download,
            bool? add)
        {
            this.View = view;
            this.Embed = embed;
            this.Comments = comments;
            this.Download = download;
            this.Add = add;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VimeoDestinationPrivacyOptions" /> class.
        /// </summary>
        public VimeoDestinationPrivacyOptions()
        {
        }
    }
}