﻿//HintName: G.Models.UsageLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage limit model.
    /// </summary>
    public sealed partial class UsageLimit
    {
        /// <summary>
        /// Type of usage limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UsageLimitType LimitType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit_value", Required = global::Newtonsoft.Json.Required.Always)]
        public int LimitValue { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimit" /> class.
        /// </summary>
        /// <param name="limitType">
        /// Type of usage limit.
        /// </param>
        /// <param name="limitValue"></param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public UsageLimit(
            global::G.UsageLimitType limitType,
            int limitValue,
            global::System.Guid tenantId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Guid? id)
        {
            this.LimitType = limitType;
            this.LimitValue = limitValue;
            this.TenantId = tenantId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimit" /> class.
        /// </summary>
        public UsageLimit()
        {
        }
    }
}