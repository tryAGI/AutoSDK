//HintName: G.Models.DialPlanEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DialPlanEntry
    {
        /// <summary>
        /// The phone number ID to use for calling the customers in this entry.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumberId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumberId { get; set; } = default!;

        /// <summary>
        /// The list of customers to call using this phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateCustomerDTO> Customers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DialPlanEntry" /> class.
        /// </summary>
        /// <param name="phoneNumberId">
        /// The phone number ID to use for calling the customers in this entry.
        /// </param>
        /// <param name="customers">
        /// The list of customers to call using this phone number.
        /// </param>
        public DialPlanEntry(
            string phoneNumberId,
            global::System.Collections.Generic.IList<global::G.CreateCustomerDTO> customers)
        {
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.Customers = customers ?? throw new global::System.ArgumentNullException(nameof(customers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DialPlanEntry" /> class.
        /// </summary>
        public DialPlanEntry()
        {
        }
    }
}