//HintName: G.Models.PostToolRouterSessionRequestExperimentalCustomToolkitTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestExperimentalCustomToolkitTool
    {
        /// <summary>
        /// Tool slug. Combined with toolkit slug to form LOCAL_&lt;TOOLKIT&gt;_&lt;TOOL&gt; (max 60 chars total).<br/>
        /// Example: GET_CUSTOMER_ORDERS
        /// </summary>
        /// <example>GET_CUSTOMER_ORDERS</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Human-readable display name<br/>
        /// Example: Get Customer Orders
        /// </summary>
        /// <example>Get Customer Orders</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Used for BM25 search matching and shown to the LLM.<br/>
        /// Example: Fetch recent orders for a customer by their email address
        /// </summary>
        /// <example>Fetch recent orders for a customer by their email address</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Must have type: "object" and a properties field.<br/>
        /// Example: {"type":"object","properties":{"email":{"type":"string","description":"Customer email"}},"required":["email"]}
        /// </summary>
        /// <example>{"type":"object","properties":{"email":{"type":"string","description":"Customer email"}},"required":["email"]}</example>
        [global::Newtonsoft.Json.JsonProperty("input_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> InputSchema { get; set; } = default!;

        /// <summary>
        /// Optional output schema for the tool response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_schema")]
        public global::System.Collections.Generic.Dictionary<string, object?>? OutputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalCustomToolkitTool" /> class.
        /// </summary>
        /// <param name="slug">
        /// Tool slug. Combined with toolkit slug to form LOCAL_&lt;TOOLKIT&gt;_&lt;TOOL&gt; (max 60 chars total).<br/>
        /// Example: GET_CUSTOMER_ORDERS
        /// </param>
        /// <param name="name">
        /// Human-readable display name<br/>
        /// Example: Get Customer Orders
        /// </param>
        /// <param name="description">
        /// Used for BM25 search matching and shown to the LLM.<br/>
        /// Example: Fetch recent orders for a customer by their email address
        /// </param>
        /// <param name="inputSchema">
        /// Must have type: "object" and a properties field.<br/>
        /// Example: {"type":"object","properties":{"email":{"type":"string","description":"Customer email"}},"required":["email"]}
        /// </param>
        /// <param name="outputSchema">
        /// Optional output schema for the tool response.
        /// </param>
        public PostToolRouterSessionRequestExperimentalCustomToolkitTool(
            string slug,
            string name,
            string description,
            global::System.Collections.Generic.Dictionary<string, object?> inputSchema,
            global::System.Collections.Generic.Dictionary<string, object?>? outputSchema)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.OutputSchema = outputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalCustomToolkitTool" /> class.
        /// </summary>
        public PostToolRouterSessionRequestExperimentalCustomToolkitTool()
        {
        }
    }
}