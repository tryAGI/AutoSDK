//HintName: G.Models.InvokePromptPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvokePromptPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Inputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokePromptPayload" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="templateFormat"></param>
        /// <param name="inputs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvokePromptPayload(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> messages,
            string templateFormat,
            object inputs)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.TemplateFormat = templateFormat ?? throw new global::System.ArgumentNullException(nameof(templateFormat));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvokePromptPayload" /> class.
        /// </summary>
        public InvokePromptPayload()
        {
        }
    }
}