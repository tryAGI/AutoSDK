//HintName: G.Models.ManifestDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManifestDescription
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"ManifestDescription"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "ManifestDescription";

        /// <summary>
        /// Field holds type of the bock to be dynamically created. Block can be initialised as step using the type declared in the field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlockType { get; set; } = default!;

        /// <summary>
        /// Description of the block to be used in manifest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Mapping name -&gt; input definition for block inputs (parameters for run() function ofdynamic block)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.DynamicInputDefinition> Inputs { get; set; } = default!;

        /// <summary>
        /// Mapping name -&gt; output kind for block outputs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::System.Collections.Generic.Dictionary<string, global::G.DynamicOutputDefinition>? Outputs { get; set; }

        /// <summary>
        /// Definition of output dimensionality offset<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_dimensionality_offset")]
        public int? OutputDimensionalityOffset { get; set; }

        /// <summary>
        /// Configuration for UI representation of the block (icon, section, etc.)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ui_manifest")]
        public object? UiManifest { get; set; }

        /// <summary>
        /// Flag to decide if function will be provided with batch data as whole or with singular batch elements while execution<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accepts_batch_input")]
        public bool? AcceptsBatchInput { get; set; }

        /// <summary>
        /// Flag to decide if empty (optional) values will be shipped as run() function parameters<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accepts_empty_values")]
        public bool? AcceptsEmptyValues { get; set; }

        /// <summary>
        /// List of batch-oriented parameters. Value will override `accepts_batch_input` if non-empty list is provided, `accepts_batch_input` is  kept not to break backward compatibility.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_oriented_parameters")]
        public global::System.Collections.Generic.IList<string>? BatchOrientedParameters { get; set; }

        /// <summary>
        /// List of parameters accepting both batches and scalars at the same time. Value will override `accepts_batch_input` if non-empty list is provided, `accepts_batch_input` is kept not to break backward compatibility.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters_with_scalars_and_batches")]
        public global::System.Collections.Generic.IList<string>? ParametersWithScalarsAndBatches { get; set; }

        /// <summary>
        /// List of parameters, for which auto-batch casting should be enforced, making sure that the block run(...) method will always receive the parameters as batches, not scalars. This property is important for blocks decreasing output dimensionality which do not define neither `batch_oriented_parameters` nor `parameters_with_scalars_and_batches`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("get_parameters_enforcing_auto_batch_casting")]
        public global::System.Collections.Generic.IList<string>? GetParametersEnforcingAutoBatchCasting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestDescription" /> class.
        /// </summary>
        /// <param name="blockType">
        /// Field holds type of the bock to be dynamically created. Block can be initialised as step using the type declared in the field.
        /// </param>
        /// <param name="inputs">
        /// Mapping name -&gt; input definition for block inputs (parameters for run() function ofdynamic block)
        /// </param>
        /// <param name="description">
        /// Description of the block to be used in manifest
        /// </param>
        /// <param name="outputs">
        /// Mapping name -&gt; output kind for block outputs.
        /// </param>
        /// <param name="outputDimensionalityOffset">
        /// Definition of output dimensionality offset<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="uiManifest">
        /// Configuration for UI representation of the block (icon, section, etc.)
        /// </param>
        /// <param name="acceptsBatchInput">
        /// Flag to decide if function will be provided with batch data as whole or with singular batch elements while execution<br/>
        /// Default Value: false
        /// </param>
        /// <param name="acceptsEmptyValues">
        /// Flag to decide if empty (optional) values will be shipped as run() function parameters<br/>
        /// Default Value: false
        /// </param>
        /// <param name="batchOrientedParameters">
        /// List of batch-oriented parameters. Value will override `accepts_batch_input` if non-empty list is provided, `accepts_batch_input` is  kept not to break backward compatibility.
        /// </param>
        /// <param name="parametersWithScalarsAndBatches">
        /// List of parameters accepting both batches and scalars at the same time. Value will override `accepts_batch_input` if non-empty list is provided, `accepts_batch_input` is kept not to break backward compatibility.
        /// </param>
        /// <param name="getParametersEnforcingAutoBatchCasting">
        /// List of parameters, for which auto-batch casting should be enforced, making sure that the block run(...) method will always receive the parameters as batches, not scalars. This property is important for blocks decreasing output dimensionality which do not define neither `batch_oriented_parameters` nor `parameters_with_scalars_and_batches`.
        /// </param>
        /// <param name="type"></param>
        public ManifestDescription(
            string blockType,
            global::System.Collections.Generic.Dictionary<string, global::G.DynamicInputDefinition> inputs,
            string? description,
            global::System.Collections.Generic.Dictionary<string, global::G.DynamicOutputDefinition>? outputs,
            int? outputDimensionalityOffset,
            object? uiManifest,
            bool? acceptsBatchInput,
            bool? acceptsEmptyValues,
            global::System.Collections.Generic.IList<string>? batchOrientedParameters,
            global::System.Collections.Generic.IList<string>? parametersWithScalarsAndBatches,
            global::System.Collections.Generic.IList<string>? getParametersEnforcingAutoBatchCasting,
            string type = "ManifestDescription")
        {
            this.Type = type;
            this.BlockType = blockType ?? throw new global::System.ArgumentNullException(nameof(blockType));
            this.Description = description;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Outputs = outputs;
            this.OutputDimensionalityOffset = outputDimensionalityOffset;
            this.UiManifest = uiManifest;
            this.AcceptsBatchInput = acceptsBatchInput;
            this.AcceptsEmptyValues = acceptsEmptyValues;
            this.BatchOrientedParameters = batchOrientedParameters;
            this.ParametersWithScalarsAndBatches = parametersWithScalarsAndBatches;
            this.GetParametersEnforcingAutoBatchCasting = getParametersEnforcingAutoBatchCasting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestDescription" /> class.
        /// </summary>
        public ManifestDescription()
        {
        }
    }
}