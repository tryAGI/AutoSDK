//HintName: G.Models.CopilotSeatBreakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The breakdown of Copilot Business seats for the organization.
    /// </summary>
    public sealed partial class CopilotSeatBreakdown
    {
        /// <summary>
        /// The total number of seats being billed for the organization as of the current billing cycle.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Seats added during the current billing cycle.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("added_this_cycle")]
        public int? AddedThisCycle { get; set; }

        /// <summary>
        /// The number of seats that are pending cancellation at the end of the current billing cycle.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_cancellation")]
        public int? PendingCancellation { get; set; }

        /// <summary>
        /// The number of seats that have been assigned to users that have not yet accepted an invitation to this organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_invitation")]
        public int? PendingInvitation { get; set; }

        /// <summary>
        /// The number of seats that have used Copilot during the current billing cycle.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_this_cycle")]
        public int? ActiveThisCycle { get; set; }

        /// <summary>
        /// The number of seats that have not used Copilot during the current billing cycle.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inactive_this_cycle")]
        public int? InactiveThisCycle { get; set; }

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
        public static global::G.CopilotSeatBreakdown? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CopilotSeatBreakdown>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CopilotSeatBreakdown?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CopilotSeatBreakdown?>(serializer.Deserialize<global::G.CopilotSeatBreakdown>(jsonReader));
        }

    }
}