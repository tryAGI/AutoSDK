//HintName: G.Models.ListCallsRequestFilterCriteriaDynamicVariables.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by dynamic variables using dot notation (e.g., `dynamic_variables.name`).<br/>
    /// Values are matched exactly as strings.<br/>
    /// Example: {"dynamic_variables.user_name":["John"]}
    /// </summary>
    public sealed partial class ListCallsRequestFilterCriteriaDynamicVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}