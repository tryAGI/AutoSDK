//HintName: G.Models.CombinedBillingUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CombinedBillingUsage
    {
        /// <summary>
        /// Numbers of days left in billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days_left_in_billing_cycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DaysLeftInBillingCycle { get; set; }

        /// <summary>
        /// Estimated storage space (GB) used in billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_paid_storage_for_month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EstimatedPaidStorageForMonth { get; set; }

        /// <summary>
        /// Estimated sum of free and paid storage space (GB) used in billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_storage_for_month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EstimatedStorageForMonth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedBillingUsage" /> class.
        /// </summary>
        /// <param name="daysLeftInBillingCycle">
        /// Numbers of days left in billing cycle.
        /// </param>
        /// <param name="estimatedPaidStorageForMonth">
        /// Estimated storage space (GB) used in billing cycle.
        /// </param>
        /// <param name="estimatedStorageForMonth">
        /// Estimated sum of free and paid storage space (GB) used in billing cycle.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CombinedBillingUsage(
            int daysLeftInBillingCycle,
            int estimatedPaidStorageForMonth,
            int estimatedStorageForMonth)
        {
            this.DaysLeftInBillingCycle = daysLeftInBillingCycle;
            this.EstimatedPaidStorageForMonth = estimatedPaidStorageForMonth;
            this.EstimatedStorageForMonth = estimatedStorageForMonth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedBillingUsage" /> class.
        /// </summary>
        public CombinedBillingUsage()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.CombinedBillingUsage? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CombinedBillingUsage),
                jsonSerializerContext) as global::G.CombinedBillingUsage;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CombinedBillingUsage? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CombinedBillingUsage>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CombinedBillingUsage?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CombinedBillingUsage),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CombinedBillingUsage;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CombinedBillingUsage?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CombinedBillingUsage?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}