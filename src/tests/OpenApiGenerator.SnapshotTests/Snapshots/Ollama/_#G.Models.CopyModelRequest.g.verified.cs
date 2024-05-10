//HintName: G.Models.CopyModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request class for copying a model.
    /// </summary>
    public sealed partial class CopyModelRequest
    {
        /// <summary>
        /// Name of the model to copy.
        /// <br/>Example: llama2:7b
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public required string Source { get; set; }

        /// <summary>
        /// Name of the new model.
        /// <br/>Example: llama2-backup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        public required string Destination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}