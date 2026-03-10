//HintName: G.Models.WhatsAppTemplateTextParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateTextParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_name")]
        public string? ParameterName { get; set; }

        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateTextParam" /> class.
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppTemplateTextParam(
            string text,
            string? parameterName,
            string? type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ParameterName = parameterName;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateTextParam" /> class.
        /// </summary>
        public WhatsAppTemplateTextParam()
        {
        }
    }
}