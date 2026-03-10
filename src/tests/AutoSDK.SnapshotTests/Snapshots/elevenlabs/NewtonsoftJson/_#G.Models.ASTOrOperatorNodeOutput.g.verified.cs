//HintName: G.Models.ASTOrOperatorNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTOrOperatorNodeOutput
    {
        /// <summary>
        /// Default Value: or_operator
        /// </summary>
        /// <default>"or_operator"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "or_operator";

        /// <summary>
        /// Child nodes of the logical operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("children", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChildrenItem4> Children { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTOrOperatorNodeOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: or_operator
        /// </param>
        /// <param name="children">
        /// Child nodes of the logical operator.
        /// </param>
        public ASTOrOperatorNodeOutput(
            global::System.Collections.Generic.IList<global::G.ChildrenItem4> children,
            string type = "or_operator")
        {
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTOrOperatorNodeOutput" /> class.
        /// </summary>
        public ASTOrOperatorNodeOutput()
        {
        }
    }
}