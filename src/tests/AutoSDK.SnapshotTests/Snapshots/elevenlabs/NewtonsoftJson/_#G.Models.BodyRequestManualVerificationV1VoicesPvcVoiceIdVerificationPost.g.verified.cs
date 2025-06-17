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
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> Files { get; set; } = default!;

        /// <summary>
        /// Extra text to be used in the manual verification process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_text")]
        public string? ExtraText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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