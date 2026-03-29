//HintName: G.Models.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigToolsVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags Tags { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigToolsVariant3" /> class.
        /// </summary>
        /// <param name="tags"></param>
        public GetToolRouterSessionBySessionIdResponseConfigToolsVariant3(
            global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags tags)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigToolsVariant3" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigToolsVariant3()
        {
        }
    }
}