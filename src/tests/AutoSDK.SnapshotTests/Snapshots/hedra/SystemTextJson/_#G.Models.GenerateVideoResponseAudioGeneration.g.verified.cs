//HintName: G.Models.GenerateVideoResponseAudioGeneration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional TTS parameters for server-side audio generation. If provided (and audio_id is not), audio will be generated from these params before video generation.
    /// </summary>
    public sealed partial class GenerateVideoResponseAudioGeneration
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}