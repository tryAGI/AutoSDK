//HintName: G.Models.CompletionTrainingParametersInWarmupFraction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// (Advanced Usage) A parameter that specifies the percentage of the total training steps at which the learning rate warm-up phase ends. During this phase, the learning rate gradually increases from a small value to the initial learning rate, helping to stabilize the training process and improve convergence. Similar to `pct_start` in [mistral-finetune](https://github.com/mistralai/mistral-finetune)<br/>
    /// Default Value: 0.05
    /// </summary>
    public sealed partial class CompletionTrainingParametersInWarmupFraction
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}