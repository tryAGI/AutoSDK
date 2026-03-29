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
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Balance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frozen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Frozen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceData" /> class.
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="frozen"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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