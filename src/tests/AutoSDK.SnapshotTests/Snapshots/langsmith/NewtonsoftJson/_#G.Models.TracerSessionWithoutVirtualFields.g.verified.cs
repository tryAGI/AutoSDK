﻿//HintName: G.Models.TracerSessionWithoutVirtualFields.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TracerSession schema.
    /// </summary>
    public sealed partial class TracerSessionWithoutVirtualFields
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_dataset_id")]
        public global::System.Guid? DefaultDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_dataset_id")]
        public global::System.Guid? ReferenceDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_tier")]
        public global::G.TraceTier? TraceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_run_start_time_live")]
        public global::System.DateTime? LastRunStartTimeLive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionWithoutVirtualFields" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="traceTier"></param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="lastRunStartTimeLive"></param>
        public TracerSessionWithoutVirtualFields(
            global::System.Guid id,
            global::System.Guid tenantId,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            object? extra,
            string? name,
            string? description,
            global::System.Guid? defaultDatasetId,
            global::System.Guid? referenceDatasetId,
            global::G.TraceTier? traceTier,
            global::System.DateTime? lastRunStartTimeLive)
        {
            this.Id = id;
            this.TenantId = tenantId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Extra = extra;
            this.Name = name;
            this.Description = description;
            this.DefaultDatasetId = defaultDatasetId;
            this.ReferenceDatasetId = referenceDatasetId;
            this.TraceTier = traceTier;
            this.LastRunStartTimeLive = lastRunStartTimeLive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionWithoutVirtualFields" /> class.
        /// </summary>
        public TracerSessionWithoutVirtualFields()
        {
        }
    }
}