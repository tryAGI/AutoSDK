//HintName: G.Models.PostToolRouterSessionRequestToolsVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestToolsVariant2
    {
        /// <summary>
        /// These specific tools will be disabled for this toolkit<br/>
        /// Example: [SLACK_ADD_EMOJI]
        /// </summary>
        /// <example>[SLACK_ADD_EMOJI]</example>
        [global::Newtonsoft.Json.JsonProperty("disable", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Disable { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant2" /> class.
        /// </summary>
        /// <param name="disable">
        /// These specific tools will be disabled for this toolkit<br/>
        /// Example: [SLACK_ADD_EMOJI]
        /// </param>
        public PostToolRouterSessionRequestToolsVariant2(
            global::System.Collections.Generic.IList<string> disable)
        {
            this.Disable = disable ?? throw new global::System.ArgumentNullException(nameof(disable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant2" /> class.
        /// </summary>
        public PostToolRouterSessionRequestToolsVariant2()
        {
        }
    }
}