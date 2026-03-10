//HintName: G.Models.PhoneNumberTransferDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberTransferDestination
    {
        /// <summary>
        /// Default Value: phone
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransferDestination" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: phone
        /// </param>
        /// <param name="phoneNumber"></param>
        public PhoneNumberTransferDestination(
            string phoneNumber,
            string? type)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransferDestination" /> class.
        /// </summary>
        public PhoneNumberTransferDestination()
        {
        }
    }
}