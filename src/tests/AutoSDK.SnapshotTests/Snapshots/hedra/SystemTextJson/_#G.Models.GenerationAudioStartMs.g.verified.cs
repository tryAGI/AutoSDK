//HintName: G.Models.GenerationAudioStartMs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio start offset in ms. Negative = prepend silence, positive = crop from start.
    /// </summary>
    public sealed partial class GenerationAudioStartMs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}