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
        [global::System.Text.Json.Serialization.JsonPropertyName("all_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<string, global::G.ToolScopeRequirementsAllOfItem>> AllOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolScopeRequirements" /> class.
        /// </summary>
        /// <param name="allOf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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