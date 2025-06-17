//HintName: G.Models.BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost
    {
        /// <summary>
        /// Verification documents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Extra text to be used in the manual verification process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_text")]
        public string? ExtraText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost" /> class.
        /// </summary>
        /// <param name="files">
        /// Verification documents
        /// </param>
        /// <param name="extraText">
        /// Extra text to be used in the manual verification process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost(
            global::System.Collections.Generic.IList<byte[]> files,
            string? extraText)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.ExtraText = extraText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost" /> class.
        /// </summary>
        public BodyRequestManualVerificationV1VoicesPvcVoiceIdVerificationPost()
        {
        }
    }
}