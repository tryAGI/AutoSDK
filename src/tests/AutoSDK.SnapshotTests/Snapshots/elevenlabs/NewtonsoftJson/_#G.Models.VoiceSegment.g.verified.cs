//HintName: G.Models.VoiceSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSegment
    {
        /// <summary>
        /// The voice ID used for this segment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// Start time of this voice segment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTimeSeconds { get; set; } = default!;

        /// <summary>
        /// End time of this voice segment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndTimeSeconds { get; set; } = default!;

        /// <summary>
        /// Start index in the characters array
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_start_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharacterStartIndex { get; set; } = default!;

        /// <summary>
        /// End index in the characters array (exclusive)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharacterEndIndex { get; set; } = default!;

        /// <summary>
        /// Line of the dialogue (script) that this segment is a part of.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dialogue_input_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int DialogueInputIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSegment" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The voice ID used for this segment
        /// </param>
        /// <param name="startTimeSeconds">
        /// Start time of this voice segment
        /// </param>
        /// <param name="endTimeSeconds">
        /// End time of this voice segment
        /// </param>
        /// <param name="characterStartIndex">
        /// Start index in the characters array
        /// </param>
        /// <param name="characterEndIndex">
        /// End index in the characters array (exclusive)
        /// </param>
        /// <param name="dialogueInputIndex">
        /// Line of the dialogue (script) that this segment is a part of.
        /// </param>
        public VoiceSegment(
            string voiceId,
            double startTimeSeconds,
            double endTimeSeconds,
            int characterStartIndex,
            int characterEndIndex,
            int dialogueInputIndex)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.StartTimeSeconds = startTimeSeconds;
            this.EndTimeSeconds = endTimeSeconds;
            this.CharacterStartIndex = characterStartIndex;
            this.CharacterEndIndex = characterEndIndex;
            this.DialogueInputIndex = dialogueInputIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSegment" /> class.
        /// </summary>
        public VoiceSegment()
        {
        }
    }
}