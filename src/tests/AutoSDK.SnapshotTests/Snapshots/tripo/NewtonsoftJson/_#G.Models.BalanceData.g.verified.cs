//HintName: G.Models.BalanceData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BalanceData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("balance", Required = global::Newtonsoft.Json.Required.Always)]
        public double Balance { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frozen", Required = global::Newtonsoft.Json.Required.Always)]
        public double Frozen { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceData" /> class.
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="frozen"></param>
        public BalanceData(
            double balance,
            double frozen)
        {
            this.Balance = balance;
            this.Frozen = frozen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceData" /> class.
        /// </summary>
        public BalanceData()
        {
        }
    }
}