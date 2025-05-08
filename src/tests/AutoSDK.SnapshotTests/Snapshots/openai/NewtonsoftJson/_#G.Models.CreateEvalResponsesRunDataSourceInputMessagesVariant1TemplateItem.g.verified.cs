//HintName: G.Models.CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem
    {
        /// <summary>
        /// The role of the message (e.g. "system", "assistant", "user").
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
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message (e.g. "system", "assistant", "user").
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
        public CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem(
            string role,
            string content)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem" /> class.
        /// </summary>
        public CreateEvalResponsesRunDataSourceInputMessagesVariant1TemplateItem()
        {
        }
    }
}