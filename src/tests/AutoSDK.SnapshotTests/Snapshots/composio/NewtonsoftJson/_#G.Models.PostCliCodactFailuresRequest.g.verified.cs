//HintName: G.Models.PostCliCodactFailuresRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCliCodactFailuresRequest
    {
        /// <summary>
        /// Type of codact failure being recorded.<br/>
        /// Example: wrong_tool_slug
        /// </summary>
        /// <example>wrong_tool_slug</example>
        [global::Newtonsoft.Json.JsonProperty("failure_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostCliCodactFailuresRequestFailureType FailureType { get; set; } = default!;

        /// <summary>
        /// Optional tool metadata when the failure can be tied to a toolkit or concrete tool version.<br/>
        /// Example: {"toolkit":"github","tool":{"slug":"GITHUB_CREATE_ISSUE","version":"2026.03.23"}}
        /// </summary>
        /// <example>{"toolkit":"github","tool":{"slug":"GITHUB_CREATE_ISSUE","version":"2026.03.23"}}</example>
        [global::Newtonsoft.Json.JsonProperty("tool_info")]
        public global::G.PostCliCodactFailuresRequestToolInfo? ToolInfo { get; set; }

        /// <summary>
        /// Arbitrary failure context from the CLI.<br/>
        /// Example: {"invalid_tool_slug":"GITHUB_MAKE_ISSUE","candidate_tool_slugs":["GITHUB_CREATE_ISSUE"]}
        /// </summary>
        /// <example>{"invalid_tool_slug":"GITHUB_MAKE_ISSUE","candidate_tool_slugs":["GITHUB_CREATE_ISSUE"]}</example>
        [global::Newtonsoft.Json.JsonProperty("ctx", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> Ctx { get; set; } = default!;

        /// <summary>
        /// Arbitrary session payload from the CLI.<br/>
        /// Example: {"id":"sess_123","model":"gpt-5.2"}
        /// </summary>
        /// <example>{"id":"sess_123","model":"gpt-5.2"}</example>
        [global::Newtonsoft.Json.JsonProperty("session", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> Session { get; set; } = default!;

        /// <summary>
        /// Optional request identifier associated with the failure.<br/>
        /// Example: req_123
        /// </summary>
        /// <example>req_123</example>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCodactFailuresRequest" /> class.
        /// </summary>
        /// <param name="failureType">
        /// Type of codact failure being recorded.<br/>
        /// Example: wrong_tool_slug
        /// </param>
        /// <param name="ctx">
        /// Arbitrary failure context from the CLI.<br/>
        /// Example: {"invalid_tool_slug":"GITHUB_MAKE_ISSUE","candidate_tool_slugs":["GITHUB_CREATE_ISSUE"]}
        /// </param>
        /// <param name="session">
        /// Arbitrary session payload from the CLI.<br/>
        /// Example: {"id":"sess_123","model":"gpt-5.2"}
        /// </param>
        /// <param name="toolInfo">
        /// Optional tool metadata when the failure can be tied to a toolkit or concrete tool version.<br/>
        /// Example: {"toolkit":"github","tool":{"slug":"GITHUB_CREATE_ISSUE","version":"2026.03.23"}}
        /// </param>
        /// <param name="requestId">
        /// Optional request identifier associated with the failure.<br/>
        /// Example: req_123
        /// </param>
        public PostCliCodactFailuresRequest(
            global::G.PostCliCodactFailuresRequestFailureType failureType,
            global::System.Collections.Generic.Dictionary<string, object?> ctx,
            global::System.Collections.Generic.Dictionary<string, object?> session,
            global::G.PostCliCodactFailuresRequestToolInfo? toolInfo,
            string? requestId)
        {
            this.FailureType = failureType;
            this.ToolInfo = toolInfo;
            this.Ctx = ctx ?? throw new global::System.ArgumentNullException(nameof(ctx));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCodactFailuresRequest" /> class.
        /// </summary>
        public PostCliCodactFailuresRequest()
        {
        }
    }
}