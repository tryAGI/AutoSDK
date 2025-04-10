//HintName: G.Models.CustomerForUpdateWithdrawalRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerForUpdateWithdrawalRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btcAddress")]
        public string? BtcAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usdtAddress")]
        public string? UsdtAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tusdtAddress")]
        public string? TusdtAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xtera")]
        public bool? Xtera { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerForUpdateWithdrawalRequestDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="btcAddress"></param>
        /// <param name="usdtAddress"></param>
        /// <param name="tusdtAddress"></param>
        /// <param name="xtera"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerForUpdateWithdrawalRequestDto(
            long? id,
            string? btcAddress,
            string? usdtAddress,
            string? tusdtAddress,
            bool? xtera)
        {
            this.Id = id;
            this.BtcAddress = btcAddress;
            this.UsdtAddress = usdtAddress;
            this.TusdtAddress = tusdtAddress;
            this.Xtera = xtera;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerForUpdateWithdrawalRequestDto" /> class.
        /// </summary>
        public CustomerForUpdateWithdrawalRequestDto()
        {
        }
    }
}