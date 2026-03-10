//HintName: G.Models.BodyGenerateCompositionPlanV1MusicPlanPostMusicLengthMs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The length of the composition plan to generate in milliseconds. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
    /// </summary>
    public sealed partial class BodyGenerateCompositionPlanV1MusicPlanPostMusicLengthMs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}