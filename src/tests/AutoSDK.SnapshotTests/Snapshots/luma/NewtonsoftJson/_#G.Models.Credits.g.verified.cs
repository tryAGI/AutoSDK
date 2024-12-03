//HintName: G.Models.Credits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The credits object
    /// </summary>
    public sealed partial class Credits
    {
        /// <summary>
        /// Available credits balance in USD cents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credit_balance", Required = global::Newtonsoft.Json.Required.Always)]
        public float CreditBalance { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Credits" /> class.
        /// </summary>
        /// <param name="creditBalance">
        /// Available credits balance in USD cents
        /// </param>
        public Credits(
            float creditBalance)
        {
            this.CreditBalance = creditBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credits" /> class.
        /// </summary>
        public Credits()
        {
        }
    }
}