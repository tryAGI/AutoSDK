//HintName: G.Models.CreditsCreateCoinbaseChargeResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditsCreateCoinbaseChargeResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreditsCoinbasePostResponsesContentApplicationJsonSchemaData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCreateCoinbaseChargeResponse200" /> class.
        /// </summary>
        /// <param name="data"></param>
        public CreditsCreateCoinbaseChargeResponse200(
            global::G.CreditsCoinbasePostResponsesContentApplicationJsonSchemaData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsCreateCoinbaseChargeResponse200" /> class.
        /// </summary>
        public CreditsCreateCoinbaseChargeResponse200()
        {
        }
    }
}