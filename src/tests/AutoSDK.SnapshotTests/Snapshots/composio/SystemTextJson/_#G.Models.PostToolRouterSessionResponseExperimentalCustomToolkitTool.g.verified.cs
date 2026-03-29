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
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> InputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public global::System.Collections.Generic.Dictionary<string, object?>? OutputSchema { get; set; }

        /// <summary>
        /// Original tool slug as provided by the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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