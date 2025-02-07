//HintName: G.Models.SetAccountCPUPMOverrideRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetAccountCPUPMOverrideRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpupmOverride")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CpupmOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAccountCPUPMOverrideRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cpupmOverride"></param>
        /// <param name="endDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetAccountCPUPMOverrideRequest(
            global::System.Guid accountId,
            double cpupmOverride,
            global::System.DateTime endDate)
        {
            this.AccountId = accountId;
            this.CpupmOverride = cpupmOverride;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAccountCPUPMOverrideRequest" /> class.
        /// </summary>
        public SetAccountCPUPMOverrideRequest()
        {
        }
    }
}