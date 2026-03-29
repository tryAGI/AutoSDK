//HintName: G.Models.ToolScopeRequirementsAllOfItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolScopeRequirementsAllOfItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("any_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AnyOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolScopeRequirementsAllOfItem" /> class.
        /// </summary>
        /// <param name="anyOf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolScopeRequirementsAllOfItem(
            global::System.Collections.Generic.IList<string> anyOf)
        {
            this.AnyOf = anyOf ?? throw new global::System.ArgumentNullException(nameof(anyOf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolScopeRequirementsAllOfItem" /> class.
        /// </summary>
        public ToolScopeRequirementsAllOfItem()
        {
        }
    }
}