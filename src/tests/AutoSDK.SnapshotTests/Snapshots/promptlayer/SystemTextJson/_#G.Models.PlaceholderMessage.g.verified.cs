//HintName: G.Models.PlaceholderMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaceholderMessage
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        public global::System.Collections.Generic.IList<string>? InputVariables { get; set; }

        /// <summary>
        /// Default Value: f-string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PlaceholderMessageTemplateFormatJsonConverter))]
        public global::G.PlaceholderMessageTemplateFormat? TemplateFormat { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.ContentVariant1Item3>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_request_display_role")]
        public string? RawRequestDisplayRole { get; set; }

        /// <summary>
        /// Default Value: placeholder
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PlaceholderMessageRoleJsonConverter))]
        public global::G.PlaceholderMessageRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceholderMessage" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputVariables">
        /// Default Value: []
        /// </param>
        /// <param name="templateFormat">
        /// Default Value: f-string
        /// </param>
        /// <param name="content">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="rawRequestDisplayRole"></param>
        /// <param name="role">
        /// Default Value: placeholder
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaceholderMessage(
            string name,
            global::System.Collections.Generic.IList<string>? inputVariables,
            global::G.PlaceholderMessageTemplateFormat? templateFormat,
            global::System.Collections.Generic.IList<global::G.ContentVariant1Item3>? content,
            string? rawRequestDisplayRole,
            global::G.PlaceholderMessageRole? role)
        {
            this.InputVariables = inputVariables;
            this.TemplateFormat = templateFormat;
            this.Content = content;
            this.RawRequestDisplayRole = rawRequestDisplayRole;
            this.Role = role;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceholderMessage" /> class.
        /// </summary>
        public PlaceholderMessage()
        {
        }
    }
}