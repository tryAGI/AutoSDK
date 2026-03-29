//HintName: G.Models.SubmitLanguageIdentificationJobRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitLanguageIdentificationJobRequest2
    {
        /// <summary>
        /// Audio/video file to identify language from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        public byte[]? Media { get; set; }

        /// <summary>
        /// Audio/video file to identify language from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medianame")]
        public string? Medianame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::G.LanguageIdentificationJobOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitLanguageIdentificationJobRequest2" /> class.
        /// </summary>
        /// <param name="media">
        /// Audio/video file to identify language from
        /// </param>
        /// <param name="medianame">
        /// Audio/video file to identify language from
        /// </param>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitLanguageIdentificationJobRequest2(
            byte[]? media,
            string? medianame,
            global::G.LanguageIdentificationJobOptions? options)
        {
            this.Media = media;
            this.Medianame = medianame;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitLanguageIdentificationJobRequest2" /> class.
        /// </summary>
        public SubmitLanguageIdentificationJobRequest2()
        {
        }
    }
}