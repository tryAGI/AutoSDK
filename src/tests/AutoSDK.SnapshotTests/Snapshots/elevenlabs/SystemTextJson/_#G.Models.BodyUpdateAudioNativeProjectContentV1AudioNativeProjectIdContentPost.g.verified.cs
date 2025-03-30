//HintName: G.Models.BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost
    {
        /// <summary>
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h5&amp;gt;More of your content&amp;lt;/h5&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h5&amp;gt;More of your content&amp;lt;/h5&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Whether to auto convert the project to audio or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_convert")]
        public bool? AutoConvert { get; set; }

        /// <summary>
        /// Whether to auto publish the new project snapshot after it's converted.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_publish")]
        public bool? AutoPublish { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost" /> class.
        /// </summary>
        /// <param name="file">
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h5&amp;gt;More of your content&amp;lt;/h5&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </param>
        /// <param name="filename">
        /// Either txt or HTML input file containing the article content. HTML should be formatted as follows '&amp;lt;html&amp;gt;&amp;lt;body&amp;gt;&amp;lt;div&amp;gt;&amp;lt;p&amp;gt;Your content&amp;lt;/p&amp;gt;&amp;lt;h5&amp;gt;More of your content&amp;lt;/h5&amp;gt;&amp;lt;p&amp;gt;Some more of your content&amp;lt;/p&amp;gt;&amp;lt;/div&amp;gt;&amp;lt;/body&amp;gt;&amp;lt;/html&amp;gt;'
        /// </param>
        /// <param name="autoConvert">
        /// Whether to auto convert the project to audio or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoPublish">
        /// Whether to auto publish the new project snapshot after it's converted.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost(
            byte[]? file,
            string? filename,
            bool? autoConvert,
            bool? autoPublish)
        {
            this.File = file;
            this.Filename = filename;
            this.AutoConvert = autoConvert;
            this.AutoPublish = autoPublish;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost" /> class.
        /// </summary>
        public BodyUpdateAudioNativeProjectContentV1AudioNativeProjectIdContentPost()
        {
        }
    }
}