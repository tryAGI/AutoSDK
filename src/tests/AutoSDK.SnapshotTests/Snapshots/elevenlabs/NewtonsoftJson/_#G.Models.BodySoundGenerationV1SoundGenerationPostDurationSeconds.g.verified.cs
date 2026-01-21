//HintName: G.Models.BodySoundGenerationV1SoundGenerationPostDurationSeconds.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the sound which will be generated in seconds. Must be at least 0.5 and at most 22. If set to None we will guess the optimal duration using the prompt. Defaults to None.
    /// </summary>
    public sealed partial class BodySoundGenerationV1SoundGenerationPostDurationSeconds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}