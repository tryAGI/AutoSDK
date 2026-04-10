//HintName: G.Models.SmsDestinationVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsDestinationVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SmsDestinationVariant2TypeJsonConverter))]
        public global::G.SmsDestinationVariant2Type Type { get; set; }

        /// <summary>
        /// Destination phone number in E.164 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsDestinationVariant2" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Destination phone number in E.164 format.
        /// </param>
        /// <param name="type"></param>
        public SmsDestinationVariant2(
            string phoneNumber,
            global::G.SmsDestinationVariant2Type type)
        {
            this.Type = type;
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsDestinationVariant2" /> class.
        /// </summary>
        public SmsDestinationVariant2()
        {
        }
    }
}