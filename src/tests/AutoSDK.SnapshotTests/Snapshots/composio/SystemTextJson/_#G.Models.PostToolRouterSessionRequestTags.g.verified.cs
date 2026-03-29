//HintName: G.Models.PostToolRouterSessionRequestTags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestTags
    {
        /// <summary>
        /// Tags that the tool must have at least one of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestTagsEnableItem>? Enable { get; set; }

        /// <summary>
        /// Tags that the tool must NOT have any of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable")]
        public global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestTagsDisableItem>? Disable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestTags" /> class.
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
        public PostToolRouterSessionRequestTags(
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestTagsEnableItem>? enable,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionRequestTagsDisableItem>? disable)
        {
            this.Enable = enable;
            this.Disable = disable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestTags" /> class.
        /// </summary>
        public PostToolRouterSessionRequestTags()
        {
        }
    }
}