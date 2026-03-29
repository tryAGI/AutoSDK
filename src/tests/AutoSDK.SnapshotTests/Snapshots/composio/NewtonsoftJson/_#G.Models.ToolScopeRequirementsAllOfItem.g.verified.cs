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
        [global::Newtonsoft.Json.JsonProperty("any_of", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AnyOf { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolScopeRequirementsAllOfItem" /> class.
        /// </summary>
        /// <param name="anyOf"></param>
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