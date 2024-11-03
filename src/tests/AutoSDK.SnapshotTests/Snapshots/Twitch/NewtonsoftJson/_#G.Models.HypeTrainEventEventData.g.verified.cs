//HintName: G.Models.HypeTrainEventEventData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event’s data.
    /// </summary>
    public sealed partial class HypeTrainEventEventData
    {
        /// <summary>
        /// The ID of the broadcaster that’s running the Hype Train.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that another Hype Train can start.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cooldown_end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CooldownEndTime { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that the Hype Train ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The value needed to reach the next level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("goal", Required = global::Newtonsoft.Json.Required.Always)]
        public int Goal { get; set; } = default!;

        /// <summary>
        /// An ID that identifies this Hype Train.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The most recent contribution towards the Hype Train’s goal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_contribution", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HypeTrainEventEventDataLastContribution LastContribution { get; set; } = default!;

        /// <summary>
        /// The highest level that the Hype Train reached (the levels are 1 through 5).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level", Required = global::Newtonsoft.Json.Required.Always)]
        public int Level { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that this Hype Train started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// The top contributors for each contribution type. For example, the top contributor using BITS (by aggregate) and the top contributor using SUBS (by count).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_contributions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.HypeTrainEventEventDataTopContribution> TopContributions { get; set; } = default!;

        /// <summary>
        /// The current total amount raised.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.HypeTrainEventEventData? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.HypeTrainEventEventData>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.HypeTrainEventEventData?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.HypeTrainEventEventData?>(serializer.Deserialize<global::G.HypeTrainEventEventData>(jsonReader));
        }

    }
}