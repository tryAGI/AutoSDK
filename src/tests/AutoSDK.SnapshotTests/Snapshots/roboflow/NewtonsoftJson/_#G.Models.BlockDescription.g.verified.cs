//HintName: G.Models.BlockDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlockDescription
    {
        /// <summary>
        /// OpenAPI specification of block manifest that can be used to create workflow step in JSON definition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object BlockSchema { get; set; } = default!;

        /// <summary>
        /// Definition of step outputs and their kinds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs_manifest", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OutputDefinition> OutputsManifest { get; set; } = default!;

        /// <summary>
        /// Name of source plugin that defines block
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_source", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlockSource { get; set; } = default!;

        /// <summary>
        /// Fully qualified class name of block implementation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fully_qualified_block_class_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FullyQualifiedBlockClassName { get; set; } = default!;

        /// <summary>
        /// Field generated based on class name providing human-friendly name of the block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("human_friendly_block_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string HumanFriendlyBlockName { get; set; } = default!;

        /// <summary>
        /// Field holds value that is used to recognise block manifest while parsing `workflow` JSON definition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest_type_identifier", Required = global::Newtonsoft.Json.Required.Always)]
        public string ManifestTypeIdentifier { get; set; } = default!;

        /// <summary>
        /// Aliases of `manifest_type_identifier` that are in use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest_type_identifier_aliases")]
        public global::System.Collections.Generic.IList<string>? ManifestTypeIdentifierAliases { get; set; }

        /// <summary>
        /// Execution Engine versions compatible with block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_engine_compatibility")]
        public string? ExecutionEngineCompatibility { get; set; }

        /// <summary>
        /// Dimensionality offsets for input parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_dimensionality_offsets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, int> InputDimensionalityOffsets { get; set; } = default!;

        /// <summary>
        /// Selected dimensionality reference property provided if different dimensionality for different inputs are supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dimensionality_reference_property")]
        public string? DimensionalityReferenceProperty { get; set; }

        /// <summary>
        /// Dimensionality offset for block output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_dimensionality_offset", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputDimensionalityOffset { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockDescription" /> class.
        /// </summary>
        /// <param name="blockSchema">
        /// OpenAPI specification of block manifest that can be used to create workflow step in JSON definition.
        /// </param>
        /// <param name="outputsManifest">
        /// Definition of step outputs and their kinds
        /// </param>
        /// <param name="blockSource">
        /// Name of source plugin that defines block
        /// </param>
        /// <param name="fullyQualifiedBlockClassName">
        /// Fully qualified class name of block implementation.
        /// </param>
        /// <param name="humanFriendlyBlockName">
        /// Field generated based on class name providing human-friendly name of the block.
        /// </param>
        /// <param name="manifestTypeIdentifier">
        /// Field holds value that is used to recognise block manifest while parsing `workflow` JSON definition.
        /// </param>
        /// <param name="inputDimensionalityOffsets">
        /// Dimensionality offsets for input parameters
        /// </param>
        /// <param name="outputDimensionalityOffset">
        /// Dimensionality offset for block output.
        /// </param>
        /// <param name="manifestTypeIdentifierAliases">
        /// Aliases of `manifest_type_identifier` that are in use.
        /// </param>
        /// <param name="executionEngineCompatibility">
        /// Execution Engine versions compatible with block.
        /// </param>
        /// <param name="dimensionalityReferenceProperty">
        /// Selected dimensionality reference property provided if different dimensionality for different inputs are supported.
        /// </param>
        public BlockDescription(
            object blockSchema,
            global::System.Collections.Generic.IList<global::G.OutputDefinition> outputsManifest,
            string blockSource,
            string fullyQualifiedBlockClassName,
            string humanFriendlyBlockName,
            string manifestTypeIdentifier,
            global::System.Collections.Generic.Dictionary<string, int> inputDimensionalityOffsets,
            int outputDimensionalityOffset,
            global::System.Collections.Generic.IList<string>? manifestTypeIdentifierAliases,
            string? executionEngineCompatibility,
            string? dimensionalityReferenceProperty)
        {
            this.BlockSchema = blockSchema ?? throw new global::System.ArgumentNullException(nameof(blockSchema));
            this.OutputsManifest = outputsManifest ?? throw new global::System.ArgumentNullException(nameof(outputsManifest));
            this.BlockSource = blockSource ?? throw new global::System.ArgumentNullException(nameof(blockSource));
            this.FullyQualifiedBlockClassName = fullyQualifiedBlockClassName ?? throw new global::System.ArgumentNullException(nameof(fullyQualifiedBlockClassName));
            this.HumanFriendlyBlockName = humanFriendlyBlockName ?? throw new global::System.ArgumentNullException(nameof(humanFriendlyBlockName));
            this.ManifestTypeIdentifier = manifestTypeIdentifier ?? throw new global::System.ArgumentNullException(nameof(manifestTypeIdentifier));
            this.ManifestTypeIdentifierAliases = manifestTypeIdentifierAliases;
            this.ExecutionEngineCompatibility = executionEngineCompatibility;
            this.InputDimensionalityOffsets = inputDimensionalityOffsets ?? throw new global::System.ArgumentNullException(nameof(inputDimensionalityOffsets));
            this.DimensionalityReferenceProperty = dimensionalityReferenceProperty;
            this.OutputDimensionalityOffset = outputDimensionalityOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockDescription" /> class.
        /// </summary>
        public BlockDescription()
        {
        }
    }
}