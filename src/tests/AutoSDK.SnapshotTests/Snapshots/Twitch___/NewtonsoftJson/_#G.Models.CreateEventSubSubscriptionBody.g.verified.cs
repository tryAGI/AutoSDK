//HintName: G.Models.CreateEventSubSubscriptionBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEventSubSubscriptionBody
    {
        /// <summary>
        /// The type of subscription to create. For a list of subscriptions that you can create, see [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types). Set this field to the value in the **Name** column of the Subscription Types table.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateEventSubSubscriptionBodyType Type { get; set; } = default!;

        /// <summary>
        /// The version number that identifies the definition of the subscription type that you want the response to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// A JSON object that contains the parameter values that are specific to the specified subscription type. For the object’s required and optional fields, see the subscription type’s documentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition", Required = global::Newtonsoft.Json.Required.Always)]
        public object Condition { get; set; } = default!;

        /// <summary>
        /// The transport details that you want Twitch to use when sending you notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateEventSubSubscriptionBodyTransport Transport { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventSubSubscriptionBody" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of subscription to create. For a list of subscriptions that you can create, see [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types). Set this field to the value in the **Name** column of the Subscription Types table.
        /// </param>
        /// <param name="version">
        /// The version number that identifies the definition of the subscription type that you want the response to use.
        /// </param>
        /// <param name="condition">
        /// A JSON object that contains the parameter values that are specific to the specified subscription type. For the object’s required and optional fields, see the subscription type’s documentation.
        /// </param>
        /// <param name="transport">
        /// The transport details that you want Twitch to use when sending you notifications.
        /// </param>
        public CreateEventSubSubscriptionBody(
            global::G.CreateEventSubSubscriptionBodyType type,
            string version,
            object condition,
            global::G.CreateEventSubSubscriptionBodyTransport transport)
        {
            this.Type = type;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventSubSubscriptionBody" /> class.
        /// </summary>
        public CreateEventSubSubscriptionBody()
        {
        }
    }
}