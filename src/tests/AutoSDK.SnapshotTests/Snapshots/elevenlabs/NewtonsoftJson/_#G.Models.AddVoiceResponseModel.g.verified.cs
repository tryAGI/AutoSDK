//HintName: G.Models.AddVoiceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"voice_id":"b38kUX8pkfYO2kHyqfFy"}
    /// </summary>
    public sealed partial class AddVoiceResponseModel
    {
        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the voice.
        /// </param>
        public AddVoiceResponseModel(
            string voiceId)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddVoiceResponseModel" /> class.
        /// </summary>
        public AddVoiceResponseModel()
        {
        }
    }
}