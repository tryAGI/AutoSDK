//HintName: G.Models.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags
    {
        /// <summary>
        /// Tags that the tool must have at least one of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>? Enabled { get; set; }

        /// <summary>
        /// Tags that the tool must NOT have any of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>? Disabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Tags that the tool must have at least one of
        /// </param>
        /// <param name="disabled">
        /// Tags that the tool must NOT have any of
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags(
            global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem>? enabled,
            global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem>? disabled)
        {
            this.Enabled = enabled;
            this.Disabled = disabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags()
        {
        }
    }
}