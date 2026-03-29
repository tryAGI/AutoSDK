//HintName: G.Models.PostToolRouterSessionBySessionIdExecuteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdExecuteRequest
    {
        /// <summary>
        /// The unique slug identifier of the tool to execute<br/>
        /// Example: GITHUB_CREATE_ISSUE
        /// </summary>
        /// <example>GITHUB_CREATE_ISSUE</example>
        [global::Newtonsoft.Json.JsonProperty("tool_slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolSlug { get; set; } = default!;

        /// <summary>
        /// The arguments required by the tool<br/>
        /// Default Value: {}<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </summary>
        /// <example>{"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}</example>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Arguments { get; set; }

        /// <summary>
        /// Account identifier to specify which connected account to use. Use the account ID (e.g. "coup_hurricane_dal_analytical") or an alias. When omitted with a single account, the default is used. When omitted with multiple accounts, an error lists available accounts.<br/>
        /// Example: coup_hurricane_dal_analytical
        /// </summary>
        /// <example>coup_hurricane_dal_analytical</example>
        [global::Newtonsoft.Json.JsonProperty("account")]
        public string? Account { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteRequest" /> class.
        /// </summary>
        /// <param name="toolSlug">
        /// The unique slug identifier of the tool to execute<br/>
        /// Example: GITHUB_CREATE_ISSUE
        /// </param>
        /// <param name="arguments">
        /// The arguments required by the tool<br/>
        /// Default Value: {}<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </param>
        /// <param name="account">
        /// Account identifier to specify which connected account to use. Use the account ID (e.g. "coup_hurricane_dal_analytical") or an alias. When omitted with a single account, the default is used. When omitted with multiple accounts, an error lists available accounts.<br/>
        /// Example: coup_hurricane_dal_analytical
        /// </param>
        public PostToolRouterSessionBySessionIdExecuteRequest(
            string toolSlug,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments,
            string? account)
        {
            this.ToolSlug = toolSlug ?? throw new global::System.ArgumentNullException(nameof(toolSlug));
            this.Arguments = arguments;
            this.Account = account;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteRequest" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteRequest()
        {
        }
    }
}