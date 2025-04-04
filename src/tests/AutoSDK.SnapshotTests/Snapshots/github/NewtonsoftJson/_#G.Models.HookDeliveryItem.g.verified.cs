﻿//HintName: G.Models.HookDeliveryItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Delivery made by a webhook, without request and response information.
    /// </summary>
    public sealed partial class HookDeliveryItem
    {
        /// <summary>
        /// Unique identifier of the webhook delivery.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the event (shared with all deliveries for all webhooks that subscribe to this event).<br/>
        /// Example: 58474f00-b361-11eb-836d-0e4f3503ccbe
        /// </summary>
        /// <example>58474f00-b361-11eb-836d-0e4f3503ccbe</example>
        [global::Newtonsoft.Json.JsonProperty("guid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Guid { get; set; } = default!;

        /// <summary>
        /// Time when the webhook delivery occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delivered_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime DeliveredAt { get; set; } = default!;

        /// <summary>
        /// Whether the webhook delivery is a redelivery.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("redelivery", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Redelivery { get; set; } = default!;

        /// <summary>
        /// Time spent delivering.<br/>
        /// Example: 0.03
        /// </summary>
        /// <example>0.03</example>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// Describes the response returned after attempting the delivery.<br/>
        /// Example: failed to connect
        /// </summary>
        /// <example>failed to connect</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Status code received when delivery was made.<br/>
        /// Example: 502
        /// </summary>
        /// <example>502</example>
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// The event that triggered the delivery.<br/>
        /// Example: issues
        /// </summary>
        /// <example>issues</example>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public string Event { get; set; } = default!;

        /// <summary>
        /// The type of activity for the event that triggered the delivery.<br/>
        /// Example: opened
        /// </summary>
        /// <example>opened</example>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Action { get; set; } = default!;

        /// <summary>
        /// The id of the GitHub App installation associated with this event.<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::Newtonsoft.Json.JsonProperty("installation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? InstallationId { get; set; } = default!;

        /// <summary>
        /// The id of the repository associated with this event.<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::Newtonsoft.Json.JsonProperty("repository_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? RepositoryId { get; set; } = default!;

        /// <summary>
        /// Time when the webhook delivery was throttled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("throttled_at")]
        public global::System.DateTime? ThrottledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HookDeliveryItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the webhook delivery.<br/>
        /// Example: 42
        /// </param>
        /// <param name="guid">
        /// Unique identifier for the event (shared with all deliveries for all webhooks that subscribe to this event).<br/>
        /// Example: 58474f00-b361-11eb-836d-0e4f3503ccbe
        /// </param>
        /// <param name="deliveredAt">
        /// Time when the webhook delivery occurred.
        /// </param>
        /// <param name="redelivery">
        /// Whether the webhook delivery is a redelivery.<br/>
        /// Example: false
        /// </param>
        /// <param name="duration">
        /// Time spent delivering.<br/>
        /// Example: 0.03
        /// </param>
        /// <param name="status">
        /// Describes the response returned after attempting the delivery.<br/>
        /// Example: failed to connect
        /// </param>
        /// <param name="statusCode">
        /// Status code received when delivery was made.<br/>
        /// Example: 502
        /// </param>
        /// <param name="event">
        /// The event that triggered the delivery.<br/>
        /// Example: issues
        /// </param>
        /// <param name="action">
        /// The type of activity for the event that triggered the delivery.<br/>
        /// Example: opened
        /// </param>
        /// <param name="installationId">
        /// The id of the GitHub App installation associated with this event.<br/>
        /// Example: 123
        /// </param>
        /// <param name="repositoryId">
        /// The id of the repository associated with this event.<br/>
        /// Example: 123
        /// </param>
        /// <param name="throttledAt">
        /// Time when the webhook delivery was throttled.
        /// </param>
        public HookDeliveryItem(
            int id,
            string guid,
            global::System.DateTime deliveredAt,
            bool redelivery,
            double duration,
            string status,
            int statusCode,
            string @event,
            string? action,
            int? installationId,
            int? repositoryId,
            global::System.DateTime? throttledAt)
        {
            this.Id = id;
            this.Guid = guid ?? throw new global::System.ArgumentNullException(nameof(guid));
            this.DeliveredAt = deliveredAt;
            this.Redelivery = redelivery;
            this.Duration = duration;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StatusCode = statusCode;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.InstallationId = installationId;
            this.RepositoryId = repositoryId;
            this.ThrottledAt = throttledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HookDeliveryItem" /> class.
        /// </summary>
        public HookDeliveryItem()
        {
        }
    }
}