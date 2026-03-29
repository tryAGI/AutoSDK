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
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdate { get; set; }

        /// <summary>
        /// The name of the service<br/>
        /// Example: search
        /// </summary>
        /// <example>search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// The health status of the service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HealthServiceStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HealthServiceStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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