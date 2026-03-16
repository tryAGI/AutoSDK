//HintName: G.Models.ResponseResultUsedCredit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseResultUsedCredit
    {
        /// <summary>
        /// The model that credits were spent on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseResultUsedCreditModel Model { get; set; } = default!;

        /// <summary>
        /// The number of credits spent on the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public int Amount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseResultUsedCredit" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that credits were spent on.
        /// </param>
        /// <param name="amount">
        /// The number of credits spent on the model.
        /// </param>
        public ResponseResultUsedCredit(
            global::G.ResponseResultUsedCreditModel model,
            int amount)
        {
            this.Model = model;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseResultUsedCredit" /> class.
        /// </summary>
        public ResponseResultUsedCredit()
        {
        }
    }
}