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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "or_operator";

        /// <summary>
        /// Child nodes of the logical operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChildrenItem4> Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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