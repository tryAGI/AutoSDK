//HintName: G.Models.PostToolsExecuteByToolSlugInputResponseArguments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Key-value pairs of arguments required by the tool to accomplish the described task<br/>
    /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
    /// </summary>
    public sealed partial class PostToolsExecuteByToolSlugInputResponseArguments
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}