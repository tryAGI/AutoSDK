//HintName: G.Models.ASTAndOperatorNodeOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTAndOperatorNodeOutput
    {
        /// <summary>
        /// Default Value: and_operator
        /// </summary>
        /// <default>"and_operator"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "and_operator";

        /// <summary>
        /// Child nodes of the logical operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("children", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChildrenItem2> Children { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTAndOperatorNodeOutput" /> class.
        /// </summary>
        /// <param name="children">
        /// Child nodes of the logical operator.
        /// </param>
        /// <param name="type">
        /// Default Value: and_operator
        /// </param>
        public ASTAndOperatorNodeOutput(
            global::System.Collections.Generic.IList<global::G.ChildrenItem2> children,
            string type = "and_operator")
        {
            this.Type = type;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTAndOperatorNodeOutput" /> class.
        /// </summary>
        public ASTAndOperatorNodeOutput()
        {
        }
    }
}