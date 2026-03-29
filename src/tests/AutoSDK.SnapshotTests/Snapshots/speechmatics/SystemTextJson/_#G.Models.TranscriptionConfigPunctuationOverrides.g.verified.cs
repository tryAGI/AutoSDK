//HintName: G.Models.TranscriptionConfigPunctuationOverrides.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Control punctuation settings.
    /// </summary>
    public sealed partial class TranscriptionConfigPunctuationOverrides
    {
        /// <summary>
        /// Ranges between zero and one. Higher values will produce more punctuation. The default is 0.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitivity")]
        public float? Sensitivity { get; set; }

        /// <summary>
        /// The punctuation marks which the client is prepared to accept in transcription output, or the special value 'all' (the default). Unsupported marks are ignored. This value is used to guide the transcription process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permitted_marks")]
        public global::System.Collections.Generic.IList<string>? PermittedMarks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigPunctuationOverrides" /> class.
        /// </summary>
        /// <param name="sensitivity">
        /// Ranges between zero and one. Higher values will produce more punctuation. The default is 0.5.
        /// </param>
        /// <param name="permittedMarks">
        /// The punctuation marks which the client is prepared to accept in transcription output, or the special value 'all' (the default). Unsupported marks are ignored. This value is used to guide the transcription process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionConfigPunctuationOverrides(
            float? sensitivity,
            global::System.Collections.Generic.IList<string>? permittedMarks)
        {
            this.Sensitivity = sensitivity;
            this.PermittedMarks = permittedMarks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfigPunctuationOverrides" /> class.
        /// </summary>
        public TranscriptionConfigPunctuationOverrides()
        {
        }
    }
}