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
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Enable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant1" /> class.
        /// </summary>
        /// <param name="enable">
        /// Only these specific tools will be available for this toolkit<br/>
        /// Example: [GMAIL_SEND_EMAIL, GMAIL_FETCH_EMAILS]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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