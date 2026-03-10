//HintName: G.Models.BodyStreamComposedMusicV1MusicStreamPostSeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Random seed to initialize the music generation process. Providing the same seed with the same parameters can help achieve more consistent results, but exact reproducibility is not guaranteed and outputs may change across system updates. Cannot be used in conjunction with prompt.
    /// </summary>
    public sealed partial class BodyStreamComposedMusicV1MusicStreamPostSeed
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}