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
        [global::System.Text.Json.Serialization.JsonPropertyName("block_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object BlockSchema { get; set; }

        /// <summary>
        /// Definition of step outputs and their kinds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_manifest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OutputDefinition> OutputsManifest { get; set; }

        /// <summary>
        /// Name of source plugin that defines block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlockSource { get; set; }

        /// <summary>
        /// Fully qualified class name of block implementation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fully_qualified_block_class_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullyQualifiedBlockClassName { get; set; }

        /// <summary>
        /// Field generated based on class name providing human-friendly name of the block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("human_friendly_block_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HumanFriendlyBlockName { get; set; }

        /// <summary>
        /// Field holds value that is used to recognise block manifest while parsing `workflow` JSON definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_type_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManifestTypeIdentifier { get; set; }

        /// <summary>
        /// Aliases of `manifest_type_identifier` that are in use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_type_identifier_aliases")]
        public global::System.Collections.Generic.IList<string>? ManifestTypeIdentifierAliases { get; set; }

        /// <summary>
        /// Execution Engine versions compatible with block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_engine_compatibility")]
        public string? ExecutionEngineCompatibility { get; set; }

        /// <summary>
        /// Dimensionality offsets for input parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_dimensionality_offsets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> InputDimensionalityOffsets { get; set; }

        /// <summary>
        /// Selected dimensionality reference property provided if different dimensionality for different inputs are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensionality_reference_property")]
        public string? DimensionalityReferenceProperty { get; set; }

        /// <summary>
        /// Dimensionality offset for block output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dimensionality_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputDimensionalityOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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