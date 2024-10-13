//HintName: G.Models.ActionsBillingUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsBillingUsage
    {
        /// <summary>
        /// The sum of the free and paid GitHub Actions minutes used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_minutes_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalMinutesUsed { get; set; } = default!;

        /// <summary>
        /// The total paid GitHub Actions minutes used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_paid_minutes_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalPaidMinutesUsed { get; set; } = default!;

        /// <summary>
        /// The amount of free GitHub Actions minutes available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("included_minutes", Required = global::Newtonsoft.Json.Required.Always)]
        public int IncludedMinutes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minutes_used_breakdown", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ActionsBillingUsageMinutesUsedBreakdown MinutesUsedBreakdown { get; set; } = default!;

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
        public static global::G.ActionsBillingUsage? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ActionsBillingUsage>(
                json,
                jsonSerializerOptions);
        }

    }
}