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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "and_operator";

        /// <summary>
        /// Child nodes of the logical operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChildrenItem2> Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTAndOperatorNodeOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: and_operator
        /// </param>
        /// <param name="children">
        /// Child nodes of the logical operator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTAndOperatorNodeOutput(
            global::System.Collections.Generic.IList<global::G.ChildrenItem2> children,
            string type = "and_operator")
        {
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTAndOperatorNodeOutput" /> class.
        /// </summary>
        public ASTAndOperatorNodeOutput()
        {
        }
    }
}