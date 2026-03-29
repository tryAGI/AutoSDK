//HintName: G.Models.PostToolRouterSessionRequestToolkitsVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enable only specific toolkits (allowlist)
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestToolkitsVariant1
    {
        /// <summary>
        /// Only these specific toolkits will be enabled<br/>
        /// Example: [gmail, slack, github]
        /// </summary>
        /// <example>[gmail, slack, github]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Enable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolkitsVariant1" /> class.
        /// </summary>
        /// <param name="enable">
        /// Only these specific toolkits will be enabled<br/>
        /// Example: [gmail, slack, github]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequestToolkitsVariant1(
            global::System.Collections.Generic.IList<string> enable)
        {
            this.Enable = enable ?? throw new global::System.ArgumentNullException(nameof(enable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolkitsVariant1" /> class.
        /// </summary>
        public PostToolRouterSessionRequestToolkitsVariant1()
        {
        }
    }
}