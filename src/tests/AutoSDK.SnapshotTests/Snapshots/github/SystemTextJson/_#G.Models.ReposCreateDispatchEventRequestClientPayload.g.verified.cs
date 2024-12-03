//HintName: G.Models.ReposCreateDispatchEventRequestClientPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON payload with extra information about the webhook event that your action or workflow may use. The maximum number of top-level properties is 10.
    /// </summary>
    public sealed partial class ReposCreateDispatchEventRequestClientPayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDispatchEventRequestClientPayload" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposCreateDispatchEventRequestClientPayload(
 )
        {
        }
    }
}