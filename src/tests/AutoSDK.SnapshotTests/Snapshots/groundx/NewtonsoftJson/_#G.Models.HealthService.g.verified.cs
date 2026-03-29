//HintName: G.Models.HealthService.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HealthService
    {
        /// <summary>
        /// The data time when the service status was last updated, in RFC3339 format<br/>
        /// Example: 2023-10-03T08:59:39.312Z
        /// </summary>
        /// <example>2023-10-03T08:59:39.312Z</example>
        [global::Newtonsoft.Json.JsonProperty("lastUpdate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUpdate { get; set; } = default!;

        /// <summary>
        /// The name of the service<br/>
        /// Example: search
        /// </summary>
        /// <example>search</example>
        [global::Newtonsoft.Json.JsonProperty("service", Required = global::Newtonsoft.Json.Required.Always)]
        public string Service { get; set; } = default!;

        /// <summary>
        /// The health status of the service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HealthServiceStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthService" /> class.
        /// </summary>
        /// <param name="lastUpdate">
        /// The data time when the service status was last updated, in RFC3339 format<br/>
        /// Example: 2023-10-03T08:59:39.312Z
        /// </param>
        /// <param name="service">
        /// The name of the service<br/>
        /// Example: search
        /// </param>
        /// <param name="status">
        /// The health status of the service
        /// </param>
        public HealthService(
            global::System.DateTime lastUpdate,
            string service,
            global::G.HealthServiceStatus status)
        {
            this.LastUpdate = lastUpdate;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthService" /> class.
        /// </summary>
        public HealthService()
        {
        }
    }
}