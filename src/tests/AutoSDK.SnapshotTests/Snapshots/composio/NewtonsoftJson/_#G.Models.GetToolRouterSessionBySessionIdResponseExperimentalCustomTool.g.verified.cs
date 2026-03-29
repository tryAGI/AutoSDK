//HintName: G.Models.GetToolRouterSessionBySessionIdResponseExperimentalCustomTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseExperimentalCustomTool
    {
        /// <summary>
        /// Prefixed tool slug (e.g. LOCAL_GMAIL_GET_IMPORTANT_EMAILS)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> InputSchema { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_schema")]
        public global::System.Collections.Generic.Dictionary<string, object?>? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extends_toolkit")]
        public string? ExtendsToolkit { get; set; }

        /// <summary>
        /// Original tool slug as provided by the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalSlug { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseExperimentalCustomTool" /> class.
        /// </summary>
        /// <param name="slug">
        /// Prefixed tool slug (e.g. LOCAL_GMAIL_GET_IMPORTANT_EMAILS)
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="inputSchema"></param>
        /// <param name="originalSlug">
        /// Original tool slug as provided by the user
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="extendsToolkit"></param>
        public GetToolRouterSessionBySessionIdResponseExperimentalCustomTool(
            string slug,
            string name,
            string description,
            global::System.Collections.Generic.Dictionary<string, object?> inputSchema,
            string originalSlug,
            global::System.Collections.Generic.Dictionary<string, object?>? outputSchema,
            string? extendsToolkit)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.OutputSchema = outputSchema;
            this.ExtendsToolkit = extendsToolkit;
            this.OriginalSlug = originalSlug ?? throw new global::System.ArgumentNullException(nameof(originalSlug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseExperimentalCustomTool" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseExperimentalCustomTool()
        {
        }
    }
}