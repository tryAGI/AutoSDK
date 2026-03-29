//HintName: G.Models.SmsContentPredefined.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsContentPredefined
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SmsContentPredefinedTypeJsonConverter))]
        public global::G.SmsContentPredefinedType? Type { get; set; }

        /// <summary>
        /// The static message to be sent in the SMS. Can contain dynamic variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsContentPredefined" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content">
        /// The static message to be sent in the SMS. Can contain dynamic variables.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsContentPredefined(
            global::G.SmsContentPredefinedType? type,
            string? content)
        {
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsContentPredefined" /> class.
        /// </summary>
        public SmsContentPredefined()
        {
        }
    }
}