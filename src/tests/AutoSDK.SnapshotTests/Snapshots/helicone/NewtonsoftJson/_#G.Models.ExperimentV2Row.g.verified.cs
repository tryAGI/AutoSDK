//HintName: G.Models.ExperimentV2Row.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentV2Row
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExperimentV2Output> Requests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_prompt_inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> AutoPromptInputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentV2Row" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="promptVersion"></param>
        /// <param name="requests"></param>
        /// <param name="autoPromptInputs"></param>
        public ExperimentV2Row(
            string id,
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            string promptVersion,
            global::System.Collections.Generic.IList<global::G.ExperimentV2Output> requests,
            global::System.Collections.Generic.IList<object> autoPromptInputs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.PromptVersion = promptVersion ?? throw new global::System.ArgumentNullException(nameof(promptVersion));
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.AutoPromptInputs = autoPromptInputs ?? throw new global::System.ArgumentNullException(nameof(autoPromptInputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentV2Row" /> class.
        /// </summary>
        public ExperimentV2Row()
        {
        }
    }
}