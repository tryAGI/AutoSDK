//HintName: G.Models.SendSMSTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendSMSTool
    {
        /// <summary>
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SendSMSToolTypeJsonConverter))]
        public global::G.SendSMSToolType Type { get; set; }

        /// <summary>
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SmsContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SmsContent SmsContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendSMSTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state edges).
        /// </param>
        /// <param name="smsContent"></param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendSMSTool(
            string name,
            global::G.SmsContent smsContent,
            global::G.SendSMSToolType type,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description;
            this.SmsContent = smsContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendSMSTool" /> class.
        /// </summary>
        public SendSMSTool()
        {
        }
    }
}