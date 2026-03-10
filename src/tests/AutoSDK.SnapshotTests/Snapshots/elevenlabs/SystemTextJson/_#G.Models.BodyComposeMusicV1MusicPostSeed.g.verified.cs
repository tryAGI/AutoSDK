//HintName: G.Models.BodyComposeMusicV1MusicPostSeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Random seed to initialize the music generation process. Providing the same seed with the same parameters can help achieve more consistent results, but exact reproducibility is not guaranteed and outputs may change across system updates. Cannot be used in conjunction with prompt.
    /// </summary>
    public sealed partial class BodyComposeMusicV1MusicPostSeed
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}