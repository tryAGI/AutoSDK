//HintName: G.Models.ToolScopeRequirements.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Structured scope requirements for the tool. Null means the tool is legacy and only exposes flat scopes.<br/>
    /// Example: {"all_of":["read:user",{"any_of":["repo","public_repo"]}]}
    /// </summary>
    public sealed partial class ToolScopeRequirements
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("all_of", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<string, global::G.ToolScopeRequirementsAllOfItem>> AllOf { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolScopeRequirements" /> class.
        /// </summary>
        /// <param name="allOf"></param>
        public ToolScopeRequirements(
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::G.ToolScopeRequirementsAllOfItem>> allOf)
        {
            this.AllOf = allOf ?? throw new global::System.ArgumentNullException(nameof(allOf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolScopeRequirements" /> class.
        /// </summary>
        public ToolScopeRequirements()
        {
        }
    }
}