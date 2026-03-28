//HintName: G.Models.ASTOrOperatorNodeInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTOrOperatorNodeInput
    {
        /// <summary>
        /// Default Value: or_operator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Child nodes of the logical operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChildrenItem3> Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTOrOperatorNodeInput" /> class.
        /// </summary>
        /// <param name="children">
        /// Child nodes of the logical operator.
        /// </param>
        /// <param name="type">
        /// Default Value: or_operator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTOrOperatorNodeInput(
            global::System.Collections.Generic.IList<global::G.ChildrenItem3> children,
            string? type)
        {
            this.Type = type;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTOrOperatorNodeInput" /> class.
        /// </summary>
        public ASTOrOperatorNodeInput()
        {
        }
    }
}