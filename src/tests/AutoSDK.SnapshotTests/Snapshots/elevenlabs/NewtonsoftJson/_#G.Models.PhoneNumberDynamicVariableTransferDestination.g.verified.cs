//HintName: G.Models.PhoneNumberDynamicVariableTransferDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberDynamicVariableTransferDestination
    {
        /// <summary>
        /// Default Value: phone_dynamic_variable
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
        /// Initializes a new instance of the <see cref="PhoneNumberDynamicVariableTransferDestination" /> class.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="type">
        /// Default Value: phone_dynamic_variable
        /// </param>
        public PhoneNumberDynamicVariableTransferDestination(
            string phoneNumber,
            string? type)
        {
            this.Type = type;
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberDynamicVariableTransferDestination" /> class.
        /// </summary>
        public PhoneNumberDynamicVariableTransferDestination()
        {
        }
    }
}