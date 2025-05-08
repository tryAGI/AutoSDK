//HintName: G.Models.EvalRunOutputItemSampleInputItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An input message.
    /// </summary>
    public sealed partial class EvalRunOutputItemSampleInputItem
    {
        /// <summary>
        /// The role of the message sender (e.g., system, user, developer).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemSampleInputItem" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message sender (e.g., system, user, developer).
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        public EvalRunOutputItemSampleInputItem(
            string role,
            string content)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemSampleInputItem" /> class.
        /// </summary>
        public EvalRunOutputItemSampleInputItem()
        {
        }
    }
}