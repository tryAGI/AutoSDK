//HintName: G.Models.WorkflowsBlocksSchemaDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowsBlocksSchemaDescription
    {
        /// <summary>
        /// Schema for validating block definitions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object Schema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowsBlocksSchemaDescription" /> class.
        /// </summary>
        /// <param name="schema">
        /// Schema for validating block definitions
        /// </param>
        public WorkflowsBlocksSchemaDescription(
            object schema)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowsBlocksSchemaDescription" /> class.
        /// </summary>
        public WorkflowsBlocksSchemaDescription()
        {
        }
    }
}