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
        [global::Newtonsoft.Json.JsonProperty("enable", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Enable { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolkitsVariant1" /> class.
        /// </summary>
        /// <param name="enable">
        /// Only these specific toolkits will be enabled<br/>
        /// Example: [gmail, slack, github]
        /// </param>
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