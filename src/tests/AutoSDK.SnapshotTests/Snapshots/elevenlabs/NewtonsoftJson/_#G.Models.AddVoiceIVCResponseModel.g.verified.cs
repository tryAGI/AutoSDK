//HintName: G.Models.AddVoiceIVCResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"requires_verification":false,"voice_id":"c38kUX8pkfYO2kHyqfFy"}
    /// </summary>
    public sealed partial class AddVoiceIVCResponseModel
    {
        /// <summary>
        /// The ID of the newly created voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// Whether the voice requires verification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requires_verification", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequiresVerification { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceIVCResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the newly created voice.
        /// </param>
        /// <param name="requiresVerification">
        /// Whether the voice requires verification
        /// </param>
        public AddVoiceIVCResponseModel(
            string voiceId,
            bool requiresVerification)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.RequiresVerification = requiresVerification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceIVCResponseModel" /> class.
        /// </summary>
        public AddVoiceIVCResponseModel()
        {
        }
    }
}