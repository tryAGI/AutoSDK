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
        [global::Newtonsoft.Json.JsonProperty("accountId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AccountId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpupmOverride", Required = global::Newtonsoft.Json.Required.Always)]
        public double CpupmOverride { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endDate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndDate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAccountCPUPMOverrideRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cpupmOverride"></param>
        /// <param name="endDate"></param>
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