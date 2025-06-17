//HintName: G.Models.BodyCreateForcedAlignmentV1ForcedAlignmentPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateForcedAlignmentV1ForcedAlignmentPost
    {
        /// <summary>
        /// The file to align. All major audio formats are supported. The file size must be less than 1GB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to align. All major audio formats are supported. The file size must be less than 1GB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The text to align with the audio. The input text can be in any format, however diarization is not supported at this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// If true, the file will be streamed to the server and processed in chunks. This is useful for large files that cannot be loaded into memory. The default is false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_spooled_file")]
        public bool? EnabledSpooledFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateForcedAlignmentV1ForcedAlignmentPost" /> class.
        /// </summary>
        /// <param name="file">
        /// The file to align. All major audio formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="filename">
        /// The file to align. All major audio formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="text">
        /// The text to align with the audio. The input text can be in any format, however diarization is not supported at this time.
        /// </param>
        /// <param name="enabledSpooledFile">
        /// If true, the file will be streamed to the server and processed in chunks. This is useful for large files that cannot be loaded into memory. The default is false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateForcedAlignmentV1ForcedAlignmentPost(
            byte[] file,
            string filename,
            string text,
            bool? enabledSpooledFile)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.EnabledSpooledFile = enabledSpooledFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateForcedAlignmentV1ForcedAlignmentPost" /> class.
        /// </summary>
        public BodyCreateForcedAlignmentV1ForcedAlignmentPost()
        {
        }
    }
}