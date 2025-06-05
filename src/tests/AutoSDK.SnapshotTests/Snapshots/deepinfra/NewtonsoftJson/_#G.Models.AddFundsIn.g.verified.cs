//HintName: G.Models.AddFundsIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddFundsIn
    {
        /// <summary>
        /// Amount to add in cents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public int Amount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFundsIn" /> class.
        /// </summary>
        /// <param name="amount">
        /// Amount to add in cents
        /// </param>
        public AddFundsIn(
            int amount)
        {
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFundsIn" /> class.
        /// </summary>
        public AddFundsIn()
        {
        }
    }
}