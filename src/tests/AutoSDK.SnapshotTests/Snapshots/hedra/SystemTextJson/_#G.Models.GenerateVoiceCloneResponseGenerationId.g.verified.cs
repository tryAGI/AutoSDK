//HintName: G.Models.GenerateVoiceCloneResponseGenerationId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional pre-reserved generation ID. If provided, this ID will be used instead of generating a new one. For batch operations (batch_size &gt; 1), use generation_ids instead.
    /// </summary>
    public sealed partial class GenerateVoiceCloneResponseGenerationId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}