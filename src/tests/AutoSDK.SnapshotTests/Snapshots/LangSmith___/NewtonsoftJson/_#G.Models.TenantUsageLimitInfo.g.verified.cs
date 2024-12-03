//HintName: G.Models.TenantUsageLimitInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantUsageLimitInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_reject_set", Required = global::Newtonsoft.Json.Required.Always)]
        public bool InRejectSet { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_limit_type")]
        public global::G.TenantUsageLimitType? UsageLimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_limit")]
        public int? TenantLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantUsageLimitInfo" /> class.
        /// </summary>
        /// <param name="inRejectSet"></param>
        /// <param name="usageLimitType"></param>
        /// <param name="tenantLimit"></param>
        public TenantUsageLimitInfo(
            bool inRejectSet,
            global::G.TenantUsageLimitType? usageLimitType,
            int? tenantLimit)
        {
            this.InRejectSet = inRejectSet;
            this.UsageLimitType = usageLimitType;
            this.TenantLimit = tenantLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantUsageLimitInfo" /> class.
        /// </summary>
        public TenantUsageLimitInfo()
        {
        }
    }
}