//HintName: G.Models.Outputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output renditions and transformations that should be generated from the source file.
    /// </summary>
    public sealed partial class Outputs
    {
        /// <summary>
        /// The output renditions and transformations that should be generated from the source file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renditions")]
        public global::System.Collections.Generic.IList<global::G.Rendition>? Renditions { get; set; }

        /// <summary>
        /// Generate a transcription of the audio in the video. The transcription can be output as a file in SRT or VTT format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::G.Transcription? Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Outputs" /> class.
        /// </summary>
        /// <param name="renditions">
        /// The output renditions and transformations that should be generated from the source file.
        /// </param>
        /// <param name="transcription">
        /// Generate a transcription of the audio in the video. The transcription can be output as a file in SRT or VTT format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Outputs(
            global::System.Collections.Generic.IList<global::G.Rendition>? renditions,
            global::G.Transcription? transcription)
        {
            this.Renditions = renditions;
            this.Transcription = transcription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Outputs" /> class.
        /// </summary>
        public Outputs()
        {
        }
    }
}