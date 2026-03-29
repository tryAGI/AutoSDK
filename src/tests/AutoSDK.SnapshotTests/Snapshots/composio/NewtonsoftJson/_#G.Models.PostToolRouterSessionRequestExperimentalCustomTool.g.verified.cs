//HintName: G.Models.PostToolRouterSessionRequestExperimentalCustomTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestExperimentalCustomTool
    {
        /// <summary>
        /// Tool slug. Forms LOCAL_&lt;TOOL&gt; (standalone) or LOCAL_&lt;TOOLKIT&gt;_&lt;TOOL&gt; (extending). Max 60 chars total.<br/>
        /// Example: GET_IMPORTANT_EMAILS
        /// </summary>
        /// <example>GET_IMPORTANT_EMAILS</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Human-readable display name<br/>
        /// Example: Get Important Emails
        /// </summary>
        /// <example>Get Important Emails</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Used for BM25 search matching and shown to the LLM.<br/>
        /// Example: Fetch emails marked as important from the last 24 hours
        /// </summary>
        /// <example>Fetch emails marked as important from the last 24 hours</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Must have type: "object" and a properties field.<br/>
        /// Example: {"type":"object","properties":{"limit":{"type":"number","description":"Max results to return"}}}
        /// </summary>
        /// <example>{"type":"object","properties":{"limit":{"type":"number","description":"Max results to return"}}}</example>
        [global::Newtonsoft.Json.JsonProperty("input_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> InputSchema { get; set; } = default!;

        /// <summary>
        /// JSON Schema describing tool output (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_schema")]
        public global::System.Collections.Generic.Dictionary<string, object?>? OutputSchema { get; set; }

        /// <summary>
        /// If set, must be a valid Composio toolkit slug. The tool inherits that toolkit's auth/connection status. If omitted, the tool is standalone (no-auth).<br/>
        /// Example: gmail
        /// </summary>
        /// <example>gmail</example>
        [global::Newtonsoft.Json.JsonProperty("extends_toolkit")]
        public string? ExtendsToolkit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalCustomTool" /> class.
        /// </summary>
        /// <param name="slug">
        /// Tool slug. Forms LOCAL_&lt;TOOL&gt; (standalone) or LOCAL_&lt;TOOLKIT&gt;_&lt;TOOL&gt; (extending). Max 60 chars total.<br/>
        /// Example: GET_IMPORTANT_EMAILS
        /// </param>
        /// <param name="name">
        /// Human-readable display name<br/>
        /// Example: Get Important Emails
        /// </param>
        /// <param name="description">
        /// Used for BM25 search matching and shown to the LLM.<br/>
        /// Example: Fetch emails marked as important from the last 24 hours
        /// </param>
        /// <param name="inputSchema">
        /// Must have type: "object" and a properties field.<br/>
        /// Example: {"type":"object","properties":{"limit":{"type":"number","description":"Max results to return"}}}
        /// </param>
        /// <param name="outputSchema">
        /// JSON Schema describing tool output (optional)
        /// </param>
        /// <param name="extendsToolkit">
        /// If set, must be a valid Composio toolkit slug. The tool inherits that toolkit's auth/connection status. If omitted, the tool is standalone (no-auth).<br/>
        /// Example: gmail
        /// </param>
        public PostToolRouterSessionRequestExperimentalCustomTool(
            string slug,
            string name,
            string description,
            global::System.Collections.Generic.Dictionary<string, object?> inputSchema,
            global::System.Collections.Generic.Dictionary<string, object?>? outputSchema,
            string? extendsToolkit)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.OutputSchema = outputSchema;
            this.ExtendsToolkit = extendsToolkit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalCustomTool" /> class.
        /// </summary>
        public PostToolRouterSessionRequestExperimentalCustomTool()
        {
        }
    }
}