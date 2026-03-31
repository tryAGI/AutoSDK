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
        [global::Newtonsoft.Json.JsonProperty("finetuned_models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FinetunedModel> FinetunedModels { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetunedModelsOutput" /> class.
        /// </summary>
        /// <param name="finetunedModels"></param>
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