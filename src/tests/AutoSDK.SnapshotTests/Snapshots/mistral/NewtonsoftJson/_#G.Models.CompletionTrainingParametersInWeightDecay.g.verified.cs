//HintName: G.Models.CompletionTrainingParametersInWeightDecay.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// (Advanced Usage) Weight decay adds a term to the loss function that is proportional to the sum of the squared weights. This term reduces the magnitude of the weights and prevents them from growing too large.<br/>
    /// Default Value: 0.1
    /// </summary>
    public sealed partial class CompletionTrainingParametersInWeightDecay
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}