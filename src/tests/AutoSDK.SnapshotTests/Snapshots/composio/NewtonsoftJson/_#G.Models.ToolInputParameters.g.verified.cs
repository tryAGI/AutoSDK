//HintName: G.Models.ToolInputParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema definition of required input parameters for the tool<br/>
    /// Example: {"repo_name":{"type":"string","description":"GitHub repository name in owner/repo format","required":true,"example":"octocat/Hello-World"},"workflow_id":{"type":"string","description":"ID or filename of the workflow to trigger","required":true,"example":"main.yml"}}
    /// </summary>
    public sealed partial class ToolInputParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}