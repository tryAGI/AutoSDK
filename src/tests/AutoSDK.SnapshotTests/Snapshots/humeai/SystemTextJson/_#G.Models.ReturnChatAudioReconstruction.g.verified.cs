//HintName: G.Models.ReturnChatAudioReconstruction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnChatAudioReconstruction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReturnChatAudioReconstructionStatusJsonConverter))]
        public global::G.ReturnChatAudioReconstructionStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_on")]
        public long? ModifiedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_audio_url")]
        public string? SignedAudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatAudioReconstruction" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="filename"></param>
        /// <param name="modifiedOn"></param>
        /// <param name="signedAudioUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReturnChatAudioReconstruction(
            string? id,
            global::G.ReturnChatAudioReconstructionStatus? status,
            string? filename,
            long? modifiedOn,
            string? signedAudioUrl)
        {
            this.Id = id;
            this.Status = status;
            this.Filename = filename;
            this.ModifiedOn = modifiedOn;
            this.SignedAudioUrl = signedAudioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatAudioReconstruction" /> class.
        /// </summary>
        public ReturnChatAudioReconstruction()
        {
        }
    }
}