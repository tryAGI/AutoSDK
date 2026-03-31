//HintName: G.Models.DatasetEventMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dictionary with additional data about the test example, model outputs, or just about anything else that's relevant, that you can use to help find and analyze examples later. For example, you could log the `prompt`, example's `id`, or anything else that would be useful to slice/dice later. The values in `metadata` can be any JSON-serializable type, but its keys must be strings
    /// </summary>
    public sealed partial class DatasetEventMetadata
    {
        /// <summary>
        /// The model used for this example
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetEventMetadata" /> class.
        /// </summary>
        /// <param name="model">
        /// The model used for this example
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetEventMetadata(
            string? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetEventMetadata" /> class.
        /// </summary>
        public DatasetEventMetadata()
        {
        }
    }
}