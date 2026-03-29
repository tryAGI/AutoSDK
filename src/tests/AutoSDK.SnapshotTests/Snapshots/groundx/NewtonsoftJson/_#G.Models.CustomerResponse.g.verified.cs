//HintName: G.Models.CustomerResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerResponse
    {
        /// <summary>
        /// Account information for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomerDetail Customer { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResponse" /> class.
        /// </summary>
        /// <param name="customer">
        /// Account information for the user
        /// </param>
        public CustomerResponse(
            global::G.CustomerDetail customer)
        {
            this.Customer = customer ?? throw new global::System.ArgumentNullException(nameof(customer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResponse" /> class.
        /// </summary>
        public CustomerResponse()
        {
        }
    }
}