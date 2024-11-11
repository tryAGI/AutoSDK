//HintName: G.Models.CreateEventSubSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEventSubSubscriptionResponse
    {
        /// <summary>
        /// A list that contains the single subscription that you created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EventSubSubscription> Data { get; set; } = default!;

        /// <summary>
        /// The total number of subscriptions you’ve created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// The sum of all of your subscription costs. [Learn More](https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCost { get; set; } = default!;

        /// <summary>
        /// The maximum total cost that you’re allowed to incur for all subscriptions you create.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxTotalCost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventSubSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the single subscription that you created.
        /// </param>
        /// <param name="total">
        /// The total number of subscriptions you’ve created.
        /// </param>
        /// <param name="totalCost">
        /// The sum of all of your subscription costs. [Learn More](https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits)
        /// </param>
        /// <param name="maxTotalCost">
        /// The maximum total cost that you’re allowed to incur for all subscriptions you create.
        /// </param>
        public CreateEventSubSubscriptionResponse(
            global::System.Collections.Generic.IList<global::G.EventSubSubscription> data,
            int total,
            int totalCost,
            int maxTotalCost)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Total = total;
            this.TotalCost = totalCost;
            this.MaxTotalCost = maxTotalCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventSubSubscriptionResponse" /> class.
        /// </summary>
        public CreateEventSubSubscriptionResponse()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CreateEventSubSubscriptionResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateEventSubSubscriptionResponse>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CreateEventSubSubscriptionResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CreateEventSubSubscriptionResponse?>(serializer.Deserialize<global::G.CreateEventSubSubscriptionResponse>(jsonReader));
        }

    }
}