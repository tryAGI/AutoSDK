//HintName: G.Models.CreateEvalLabelModelGrader.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A LabelModelGrader object which uses a model to assign labels to each item<br/>
    /// in the evaluation.
    /// </summary>
    public sealed partial class CreateEvalLabelModelGrader
    {
        /// <summary>
        /// The object type, which is always `label_model`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateEvalLabelModelGraderType Type { get; set; }

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The model to use for the evaluation. Must support structured outputs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// A list of chat messages forming the prompt or context. May include variable references to the `item` namespace, ie {{item.name}}.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateEvalItem> Input { get; set; } = default!;

        /// <summary>
        /// The labels to classify to each item in the evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Labels { get; set; } = default!;

        /// <summary>
        /// The labels that indicate a passing result. Must be a subset of labels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passing_labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> PassingLabels { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalLabelModelGrader" /> class.
        /// </summary>
        /// <param name="type">
        /// The object type, which is always `label_model`.
        /// </param>
        /// <param name="name">
        /// The name of the grader.
        /// </param>
        /// <param name="model">
        /// The model to use for the evaluation. Must support structured outputs.
        /// </param>
        /// <param name="input">
        /// A list of chat messages forming the prompt or context. May include variable references to the `item` namespace, ie {{item.name}}.
        /// </param>
        /// <param name="labels">
        /// The labels to classify to each item in the evaluation.
        /// </param>
        /// <param name="passingLabels">
        /// The labels that indicate a passing result. Must be a subset of labels.
        /// </param>
        public CreateEvalLabelModelGrader(
            string name,
            string model,
            global::System.Collections.Generic.IList<global::G.CreateEvalItem> input,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Collections.Generic.IList<string> passingLabels,
            global::G.CreateEvalLabelModelGraderType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.PassingLabels = passingLabels ?? throw new global::System.ArgumentNullException(nameof(passingLabels));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalLabelModelGrader" /> class.
        /// </summary>
        public CreateEvalLabelModelGrader()
        {
        }
    }
}