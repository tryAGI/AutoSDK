//HintName: G.Models.ASTAndOperatorNodeInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTAndOperatorNodeInput
    {
        /// <summary>
        /// Default Value: and_operator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Child nodes of the logical operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("children", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChildrenItem> Children { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTAndOperatorNodeInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: and_operator
        /// </param>
        /// <param name="children">
        /// Child nodes of the logical operator.
        /// </param>
        public ASTAndOperatorNodeInput(
            global::System.Collections.Generic.IList<global::G.ChildrenItem> children,
            string? type)
        {
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTAndOperatorNodeInput" /> class.
        /// </summary>
        public ASTAndOperatorNodeInput()
        {
        }
    }
}