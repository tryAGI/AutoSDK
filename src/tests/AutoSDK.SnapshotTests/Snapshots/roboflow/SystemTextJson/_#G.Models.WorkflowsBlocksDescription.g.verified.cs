//HintName: G.Models.WorkflowsBlocksDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowsBlocksDescription
    {
        /// <summary>
        /// List of loaded blocks descriptions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BlockDescription> Blocks { get; set; }

        /// <summary>
        /// List of kinds defined for blocks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_kinds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Kind> DeclaredKinds { get; set; }

        /// <summary>
        /// Mapping from kind name into list of blocks properties accepting references of that kind
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kinds_connections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.ExternalWorkflowsBlockSelectorDefinition>> KindsConnections { get; set; }

        /// <summary>
        /// List defining all properties for all blocks that can be filled with primitive values in workflow definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primitives_connections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExternalBlockPropertyPrimitiveDefinition> PrimitivesConnections { get; set; }

        /// <summary>
        /// Definitions of Universal Query Language operations and operators
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("universal_query_language_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UniversalQueryLanguageDescription UniversalQueryLanguageDescription { get; set; }

        /// <summary>
        /// Schema for dynamic block definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_block_definition_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DynamicBlockDefinitionSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowsBlocksDescription" /> class.
        /// </summary>
        /// <param name="blocks">
        /// List of loaded blocks descriptions
        /// </param>
        /// <param name="declaredKinds">
        /// List of kinds defined for blocks
        /// </param>
        /// <param name="kindsConnections">
        /// Mapping from kind name into list of blocks properties accepting references of that kind
        /// </param>
        /// <param name="primitivesConnections">
        /// List defining all properties for all blocks that can be filled with primitive values in workflow definition.
        /// </param>
        /// <param name="universalQueryLanguageDescription">
        /// Definitions of Universal Query Language operations and operators
        /// </param>
        /// <param name="dynamicBlockDefinitionSchema">
        /// Schema for dynamic block definition
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowsBlocksDescription(
            global::System.Collections.Generic.IList<global::G.BlockDescription> blocks,
            global::System.Collections.Generic.IList<global::G.Kind> declaredKinds,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.ExternalWorkflowsBlockSelectorDefinition>> kindsConnections,
            global::System.Collections.Generic.IList<global::G.ExternalBlockPropertyPrimitiveDefinition> primitivesConnections,
            global::G.UniversalQueryLanguageDescription universalQueryLanguageDescription,
            object dynamicBlockDefinitionSchema)
        {
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
            this.DeclaredKinds = declaredKinds ?? throw new global::System.ArgumentNullException(nameof(declaredKinds));
            this.KindsConnections = kindsConnections ?? throw new global::System.ArgumentNullException(nameof(kindsConnections));
            this.PrimitivesConnections = primitivesConnections ?? throw new global::System.ArgumentNullException(nameof(primitivesConnections));
            this.UniversalQueryLanguageDescription = universalQueryLanguageDescription ?? throw new global::System.ArgumentNullException(nameof(universalQueryLanguageDescription));
            this.DynamicBlockDefinitionSchema = dynamicBlockDefinitionSchema ?? throw new global::System.ArgumentNullException(nameof(dynamicBlockDefinitionSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowsBlocksDescription" /> class.
        /// </summary>
        public WorkflowsBlocksDescription()
        {
        }
    }
}