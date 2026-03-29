//HintName: G.Models.PostToolRouterSessionRequestToolkitsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Disable specific toolkits (denylist)
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestToolkitsVariant2
    {
        /// <summary>
        /// These specific toolkits will be disabled<br/>
        /// Example: [gmail, slack]
        /// </summary>
        /// <example>[gmail, slack]</example>
        [global::Newtonsoft.Json.JsonProperty("disable", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Disable { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolkitsVariant2" /> class.
        /// </summary>
        /// <param name="disable">
        /// These specific toolkits will be disabled<br/>
        /// Example: [gmail, slack]
        /// </param>
        public PostToolRouterSessionRequestToolkitsVariant2(
            global::System.Collections.Generic.IList<string> disable)
        {
            this.Disable = disable ?? throw new global::System.ArgumentNullException(nameof(disable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolkitsVariant2" /> class.
        /// </summary>
        public PostToolRouterSessionRequestToolkitsVariant2()
        {
        }
    }
}