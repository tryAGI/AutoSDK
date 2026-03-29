//HintName: G.Models.GetToolRouterSessionBySessionIdResponseConfigTags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MCP tool annotation hints for filtering tools with enabled/disabled support. enabled: tags that the tool must have at least one of. disabled: tags that the tool must NOT have any of. Both conditions must be satisfied.
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigTags
    {
        /// <summary>
        /// Tags that the tool must have at least one of
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? Enabled { get; set; }

        /// <summary>
        /// Tags that the tool must NOT have any of
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled")]
        public global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigTags" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Tags that the tool must have at least one of
        /// </param>
        /// <param name="disabled">
        /// Tags that the tool must NOT have any of
        /// </param>
        public GetToolRouterSessionBySessionIdResponseConfigTags(
            global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? enabled,
            global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? disabled)
        {
            this.Enabled = enabled;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigTags" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigTags()
        {
        }
    }
}