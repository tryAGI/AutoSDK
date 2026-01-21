//HintName: G.Models.ModelSettingsResponseModelUseSpeakerBoost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This setting boosts the similarity to the original speaker. Using this setting requires a slightly higher computational load, which in turn increases latency.
    /// </summary>
    public sealed partial class ModelSettingsResponseModelUseSpeakerBoost
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}