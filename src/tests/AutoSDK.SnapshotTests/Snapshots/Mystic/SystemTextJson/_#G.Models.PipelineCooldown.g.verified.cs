//HintName: G.Models.PipelineCooldown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineCooldown
    {
        /// <summary>
        /// Default Value: 1800
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int Duration { get; set; } = 1800;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}