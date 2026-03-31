//HintName: G.Models.FinetunedModelsOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetunedModelsOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetuned_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FinetunedModel> FinetunedModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetunedModelsOutput" /> class.
        /// </summary>
        /// <param name="finetunedModels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FinetunedModelsOutput(
            global::System.Collections.Generic.IList<global::G.FinetunedModel> finetunedModels)
        {
            this.FinetunedModels = finetunedModels ?? throw new global::System.ArgumentNullException(nameof(finetunedModels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetunedModelsOutput" /> class.
        /// </summary>
        public FinetunedModelsOutput()
        {
        }
    }
}