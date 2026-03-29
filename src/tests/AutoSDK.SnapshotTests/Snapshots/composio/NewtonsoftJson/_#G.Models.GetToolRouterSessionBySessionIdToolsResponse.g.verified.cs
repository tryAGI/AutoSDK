//HintName: G.Models.GetToolRouterSessionBySessionIdToolsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdToolsResponse
    {
        /// <summary>
        /// List of tools with their complete schemas
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Tool> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdToolsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// List of tools with their complete schemas
        /// </param>
        public GetToolRouterSessionBySessionIdToolsResponse(
            global::System.Collections.Generic.IList<global::G.Tool> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdToolsResponse" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdToolsResponse()
        {
        }
    }
}