//HintName: G.Models.CallBatchError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallBatchError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateCustomerDTO Customer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchError" /> class.
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="error"></param>
        public CallBatchError(
            global::G.CreateCustomerDTO customer,
            string error)
        {
            this.Customer = customer ?? throw new global::System.ArgumentNullException(nameof(customer));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchError" /> class.
        /// </summary>
        public CallBatchError()
        {
        }
    }
}