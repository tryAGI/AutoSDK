//HintName: G.Models.PostToolRouterSessionResponseExperimentalCustomToolkitTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionResponseExperimentalCustomToolkitTool
    {
        /// <summary>
        /// Prefixed tool slug (e.g. LOCAL_CRM_FIND_CUSTOMER)
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
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseExperimentalCustomToolkitTool" /> class.
        /// </summary>
        /// <param name="slug">
        /// Prefixed tool slug (e.g. LOCAL_CRM_FIND_CUSTOMER)
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="inputSchema"></param>
        /// <param name="originalSlug">
        /// Original tool slug as provided by the user
        /// </param>
        /// <param name="outputSchema"></param>
        public PostToolRouterSessionResponseExperimentalCustomToolkitTool(
            string slug,
            string name,
            string description,
            global::System.Collections.Generic.Dictionary<string, object?> inputSchema,
            string originalSlug,
            global::System.Collections.Generic.Dictionary<string, object?>? outputSchema)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.OutputSchema = outputSchema;
            this.OriginalSlug = originalSlug ?? throw new global::System.ArgumentNullException(nameof(originalSlug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseExperimentalCustomToolkitTool" /> class.
        /// </summary>
        public PostToolRouterSessionResponseExperimentalCustomToolkitTool()
        {
        }
    }
}