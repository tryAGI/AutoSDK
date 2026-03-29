//HintName: G.Models.PostToolRouterSessionRequestToolsVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestToolsVariant1
    {
        /// <summary>
        /// Only these specific tools will be available for this toolkit<br/>
        /// Example: [GMAIL_SEND_EMAIL, GMAIL_FETCH_EMAILS]
        /// </summary>
        /// <example>[GMAIL_SEND_EMAIL, GMAIL_FETCH_EMAILS]</example>
        [global::Newtonsoft.Json.JsonProperty("enable", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Enable { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant1" /> class.
        /// </summary>
        /// <param name="enable">
        /// Only these specific tools will be available for this toolkit<br/>
        /// Example: [GMAIL_SEND_EMAIL, GMAIL_FETCH_EMAILS]
        /// </param>
        public PostToolRouterSessionRequestToolsVariant1(
            global::System.Collections.Generic.IList<string> enable)
        {
            this.Enable = enable ?? throw new global::System.ArgumentNullException(nameof(enable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant1" /> class.
        /// </summary>
        public PostToolRouterSessionRequestToolsVariant1()
        {
        }
    }
}