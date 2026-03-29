//HintName: G.Models.CodeToolResponseVariables.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A mapping of variable names to JSON paths in the code execution result. These mapped values will be extracted and added as dynamic variables.<br/>
    /// Example: {"order_id":"data.order.id"}
    /// </summary>
    public sealed partial class CodeToolResponseVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}