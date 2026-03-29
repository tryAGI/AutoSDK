//HintName: G.Models.PostToolsExecuteByToolSlugResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool execution output data that varies based on the specific tool<br/>
    /// Example: {"run_id":12345678,"status":"queued","created_at":"2023-01-01T12:00:00Z","html_url":"https://github.com/octocat/Hello-World/actions/runs/12345678"}
    /// </summary>
    public sealed partial class PostToolsExecuteByToolSlugResponseData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}