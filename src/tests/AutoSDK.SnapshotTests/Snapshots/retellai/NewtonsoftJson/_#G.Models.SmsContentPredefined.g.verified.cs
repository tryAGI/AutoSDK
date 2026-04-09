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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SmsContentPredefinedTypeJsonConverter))]
        public global::G.SmsContentPredefinedType? Type { get; set; }

        /// <summary>
        /// The static message to be sent in the SMS. Can contain dynamic variables.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsContentPredefined" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content">
        /// The static message to be sent in the SMS. Can contain dynamic variables.
        /// </param>
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