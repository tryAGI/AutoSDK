//HintName: G.Models.BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost
    {
        /// <summary>
        /// Name to use for the created voice.<br/>
        /// Example: Sassy squeaky mouse
        /// </summary>
        /// <example>Sassy squeaky mouse</example>
        [global::Newtonsoft.Json.JsonProperty("voice_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceName { get; set; } = default!;

        /// <summary>
        /// Description to use for the created voice.<br/>
        /// Example: A sassy squeaky mouse
        /// </summary>
        /// <example>A sassy squeaky mouse</example>
        [global::Newtonsoft.Json.JsonProperty("voice_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceDescription { get; set; } = default!;

        /// <summary>
        /// The generated_voice_id to create, call POST /v1/text-to-voice/create-previews and fetch the generated_voice_id from the response header if don't have one yet.<br/>
        /// Example: 37HceQefKmEi3bGovXjL
        /// </summary>
        /// <example>37HceQefKmEi3bGovXjL</example>
        [global::Newtonsoft.Json.JsonProperty("generated_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GeneratedVoiceId { get; set; } = default!;

        /// <summary>
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// List of voice ids that the user has played but not selected. Used for RLHF.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("played_not_selected_voice_ids")]
        public global::System.Collections.Generic.IList<string>? PlayedNotSelectedVoiceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost" /> class.
        /// </summary>
        /// <param name="voiceName">
        /// Name to use for the created voice.<br/>
        /// Example: Sassy squeaky mouse
        /// </param>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.<br/>
        /// Example: A sassy squeaky mouse
        /// </param>
        /// <param name="generatedVoiceId">
        /// The generated_voice_id to create, call POST /v1/text-to-voice/create-previews and fetch the generated_voice_id from the response header if don't have one yet.<br/>
        /// Example: 37HceQefKmEi3bGovXjL
        /// </param>
        /// <param name="labels">
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </param>
        /// <param name="playedNotSelectedVoiceIds">
        /// List of voice ids that the user has played but not selected. Used for RLHF.
        /// </param>
        public BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost(
            string voiceName,
            string voiceDescription,
            string generatedVoiceId,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::System.Collections.Generic.IList<string>? playedNotSelectedVoiceIds)
        {
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
            this.VoiceDescription = voiceDescription ?? throw new global::System.ArgumentNullException(nameof(voiceDescription));
            this.GeneratedVoiceId = generatedVoiceId ?? throw new global::System.ArgumentNullException(nameof(generatedVoiceId));
            this.Labels = labels;
            this.PlayedNotSelectedVoiceIds = playedNotSelectedVoiceIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost" /> class.
        /// </summary>
        public BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost()
        {
        }
    }
}