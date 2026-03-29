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
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Display name shown to the LLM and in search results.<br/>
        /// Example: E-Commerce API
        /// </summary>
        /// <example>E-Commerce API</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Used for BM25 search matching and shown in toolkit connection statuses.<br/>
        /// Example: Internal e-commerce API for order management and fulfillment
        /// </summary>
        /// <example>Internal e-commerce API for order management and fulfillment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Tools in this custom toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestExperimentalCustomToolkitTool> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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