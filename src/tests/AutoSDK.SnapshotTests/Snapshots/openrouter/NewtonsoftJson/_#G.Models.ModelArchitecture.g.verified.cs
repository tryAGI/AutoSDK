//HintName: G.Models.ModelArchitecture.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model architecture information
    /// </summary>
    public sealed partial class ModelArchitecture
    {
        /// <summary>
        /// Tokenizer type used by the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenizer")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelGroupJsonConverter))]
        public global::G.ModelGroup? Tokenizer { get; set; }

        /// <summary>
        /// Instruction format type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instruct_type")]
        public global::G.OneOf<global::G.ModelArchitectureInstructType?, object>? InstructType { get; set; }

        /// <summary>
        /// Primary modality of the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modality")]
        public string? Modality { get; set; }

        /// <summary>
        /// Supported input modalities
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_modalities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InputModality> InputModalities { get; set; } = default!;

        /// <summary>
        /// Supported output modalities
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_modalities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OutputModality> OutputModalities { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelArchitecture" /> class.
        /// </summary>
        /// <param name="inputModalities">
        /// Supported input modalities
        /// </param>
        /// <param name="outputModalities">
        /// Supported output modalities
        /// </param>
        /// <param name="tokenizer">
        /// Tokenizer type used by the model
        /// </param>
        /// <param name="instructType">
        /// Instruction format type
        /// </param>
        /// <param name="modality">
        /// Primary modality of the model
        /// </param>
        public ModelArchitecture(
            global::System.Collections.Generic.IList<global::G.InputModality> inputModalities,
            global::System.Collections.Generic.IList<global::G.OutputModality> outputModalities,
            global::G.ModelGroup? tokenizer,
            global::G.OneOf<global::G.ModelArchitectureInstructType?, object>? instructType,
            string? modality)
        {
            this.Tokenizer = tokenizer;
            this.InstructType = instructType;
            this.Modality = modality;
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelArchitecture" /> class.
        /// </summary>
        public ModelArchitecture()
        {
        }
    }
}