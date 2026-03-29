//HintName: G.Models.InferenceObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Arbitrary data, used as input for the embedding model. Used if the model requires more than one input or a custom input.
    /// </summary>
    public sealed partial class InferenceObjectObject
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}