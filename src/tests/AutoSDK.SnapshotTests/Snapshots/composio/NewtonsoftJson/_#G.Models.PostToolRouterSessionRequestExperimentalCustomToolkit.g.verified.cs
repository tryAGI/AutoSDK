//HintName: G.Models.PostToolRouterSessionRequestExperimentalCustomToolkit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestExperimentalCustomToolkit
    {
        /// <summary>
        /// Unique slug for the toolkit. Must not conflict with existing Composio toolkit slugs. Alphanumeric, underscores, and hyphens only.<br/>
        /// Example: ecommerce
        /// </summary>
        /// <example>ecommerce</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Display name shown to the LLM and in search results.<br/>
        /// Example: E-Commerce API
        /// </summary>
        /// <example>E-Commerce API</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Used for BM25 search matching and shown in toolkit connection statuses.<br/>
        /// Example: Internal e-commerce API for order management and fulfillment
        /// </summary>
        /// <example>Internal e-commerce API for order management and fulfillment</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Tools in this custom toolkit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestExperimentalCustomToolkitTool> Tools { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalCustomToolkit" /> class.
        /// </summary>
        /// <param name="slug">
        /// Unique slug for the toolkit. Must not conflict with existing Composio toolkit slugs. Alphanumeric, underscores, and hyphens only.<br/>
        /// Example: ecommerce
        /// </param>
        /// <param name="name">
        /// Display name shown to the LLM and in search results.<br/>
        /// Example: E-Commerce API
        /// </param>
        /// <param name="description">
        /// Used for BM25 search matching and shown in toolkit connection statuses.<br/>
        /// Example: Internal e-commerce API for order management and fulfillment
        /// </param>
        /// <param name="tools">
        /// Tools in this custom toolkit
        /// </param>
        public PostToolRouterSessionRequestExperimentalCustomToolkit(
            string slug,
            string name,
            string description,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestExperimentalCustomToolkitTool> tools)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalCustomToolkit" /> class.
        /// </summary>
        public PostToolRouterSessionRequestExperimentalCustomToolkit()
        {
        }
    }
}