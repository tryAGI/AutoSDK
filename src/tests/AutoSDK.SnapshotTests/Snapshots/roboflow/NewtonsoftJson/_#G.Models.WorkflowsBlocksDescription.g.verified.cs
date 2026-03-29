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
        [global::Newtonsoft.Json.JsonProperty("blocks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BlockDescription> Blocks { get; set; } = default!;

        /// <summary>
        /// List of kinds defined for blocks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("declared_kinds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Kind> DeclaredKinds { get; set; } = default!;

        /// <summary>
        /// Mapping from kind name into list of blocks properties accepting references of that kind
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kinds_connections", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.ExternalWorkflowsBlockSelectorDefinition>> KindsConnections { get; set; } = default!;

        /// <summary>
        /// List defining all properties for all blocks that can be filled with primitive values in workflow definition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("primitives_connections", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExternalBlockPropertyPrimitiveDefinition> PrimitivesConnections { get; set; } = default!;

        /// <summary>
        /// Definitions of Universal Query Language operations and operators
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("universal_query_language_description", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UniversalQueryLanguageDescription UniversalQueryLanguageDescription { get; set; } = default!;

        /// <summary>
        /// Schema for dynamic block definition
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_block_definition_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object DynamicBlockDefinitionSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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