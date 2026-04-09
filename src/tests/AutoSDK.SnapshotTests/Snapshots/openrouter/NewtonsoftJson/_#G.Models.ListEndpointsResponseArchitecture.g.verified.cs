//HintName: G.Models.ListEndpointsResponseArchitecture.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListEndpointsResponseArchitecture
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenizer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListEndpointsResponseArchitectureTokenizer Tokenizer { get; set; } = default!;

        /// <summary>
        /// Instruction format type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instruct_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InstructType2JsonConverter))]
        public global::G.InstructType2 InstructType { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ListEndpointsResponseArchitecture" /> class.
        /// </summary>
        /// <param name="tokenizer"></param>
        /// <param name="instructType">
        /// Instruction format type
        /// </param>
        /// <param name="inputModalities">
        /// Supported input modalities
        /// </param>
        /// <param name="outputModalities">
        /// Supported output modalities
        /// </param>
        /// <param name="modality">
        /// Primary modality of the model
        /// </param>
        public ListEndpointsResponseArchitecture(
            global::G.ListEndpointsResponseArchitectureTokenizer tokenizer,
            global::G.InstructType2 instructType,
            global::System.Collections.Generic.IList<global::G.InputModality> inputModalities,
            global::System.Collections.Generic.IList<global::G.OutputModality> outputModalities,
            string? modality)
        {
            this.Tokenizer = tokenizer ?? throw new global::System.ArgumentNullException(nameof(tokenizer));
            this.InstructType = instructType;
            this.Modality = modality;
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponseArchitecture" /> class.
        /// </summary>
        public ListEndpointsResponseArchitecture()
        {
        }
    }
}