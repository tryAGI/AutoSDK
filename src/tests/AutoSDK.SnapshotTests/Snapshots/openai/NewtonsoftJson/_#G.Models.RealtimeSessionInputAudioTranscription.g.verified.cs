//HintName: G.Models.RealtimeSessionInputAudioTranscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for input audio transcription, defaults to off and can be <br/>
    /// set to `null` to turn off once on. Input audio transcription is not native <br/>
    /// to the model, since the model consumes audio directly. Transcription runs <br/>
    /// asynchronously through Whisper and should be treated as rough guidance <br/>
    /// rather than the representation understood by the model.
    /// </summary>
    public sealed partial class RealtimeSessionInputAudioTranscription
    {
        /// <summary>
        /// The model to use for transcription, `whisper-1` is the only currently <br/>
        /// supported model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionInputAudioTranscription" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for transcription, `whisper-1` is the only currently <br/>
        /// supported model.
        /// </param>
        public RealtimeSessionInputAudioTranscription(
            string? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionInputAudioTranscription" /> class.
        /// </summary>
        public RealtimeSessionInputAudioTranscription()
        {
        }
    }
}