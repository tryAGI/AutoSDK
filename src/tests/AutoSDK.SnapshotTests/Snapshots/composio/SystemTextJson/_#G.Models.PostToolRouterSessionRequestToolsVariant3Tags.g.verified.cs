//HintName: G.Models.PostToolRouterSessionRequestToolsVariant3Tags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestToolsVariant3Tags
    {
        /// <summary>
        /// Tags that the tool must have at least one of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestToolsVariant3TagsEnableItem>? Enable { get; set; }

        /// <summary>
        /// Tags that the tool must NOT have any of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable")]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestToolsVariant3TagsDisableItem>? Disable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant3Tags" /> class.
        /// </summary>
        /// <param name="enable">
        /// Tags that the tool must have at least one of
        /// </param>
        /// <param name="disable">
        /// Tags that the tool must NOT have any of
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequestToolsVariant3Tags(
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestToolsVariant3TagsEnableItem>? enable,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestToolsVariant3TagsDisableItem>? disable)
        {
            this.Enable = enable;
            this.Disable = disable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant3Tags" /> class.
        /// </summary>
        public PostToolRouterSessionRequestToolsVariant3Tags()
        {
        }
    }
}