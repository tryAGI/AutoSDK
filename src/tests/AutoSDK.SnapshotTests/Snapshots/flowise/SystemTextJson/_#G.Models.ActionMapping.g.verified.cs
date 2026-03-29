//HintName: G.Models.ActionMapping.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionMapping
    {
        /// <summary>
        /// Example: Yes
        /// </summary>
        /// <example>Yes</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("approve")]
        public string? Approve { get; set; }

        /// <summary>
        /// Example: No
        /// </summary>
        /// <example>No</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reject")]
        public string? Reject { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCalls")]
        public byte[]? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionMapping" /> class.
        /// </summary>
        /// <param name="approve">
        /// Example: Yes
        /// </param>
        /// <param name="reject">
        /// Example: No
        /// </param>
        /// <param name="toolCalls">
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionMapping(
            string? approve,
            string? reject,
            byte[]? toolCalls)
        {
            this.Approve = approve;
            this.Reject = reject;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionMapping" /> class.
        /// </summary>
        public ActionMapping()
        {
        }
    }
}