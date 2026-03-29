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
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Tool> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdToolsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// List of tools with their complete schemas
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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