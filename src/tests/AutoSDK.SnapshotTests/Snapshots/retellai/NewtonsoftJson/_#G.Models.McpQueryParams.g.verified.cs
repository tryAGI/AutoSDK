//HintName: G.Models.McpQueryParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query parameters to append to the  MCP connection request URL.<br/>
    /// Example: {"index":"1","key":"value"}
    /// </summary>
    public sealed partial class McpQueryParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}