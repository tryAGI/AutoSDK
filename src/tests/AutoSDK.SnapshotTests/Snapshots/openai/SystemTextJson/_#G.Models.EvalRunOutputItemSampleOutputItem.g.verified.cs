//HintName: G.Models.EvalRunOutputItemSampleOutputItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalRunOutputItemSampleOutputItem
    {
        /// <summary>
        /// The role of the message (e.g. "system", "assistant", "user").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemSampleOutputItem" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message (e.g. "system", "assistant", "user").
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRunOutputItemSampleOutputItem(
            string? role,
            string? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemSampleOutputItem" /> class.
        /// </summary>
        public EvalRunOutputItemSampleOutputItem()
        {
        }
    }
}