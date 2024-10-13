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


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
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

        public static global::G.CombinedBillingUsage? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CombinedBillingUsage),
                jsonSerializerContext) as global::G.CombinedBillingUsage;
        }

#if NET6_0_OR_GREATER
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

    }
}