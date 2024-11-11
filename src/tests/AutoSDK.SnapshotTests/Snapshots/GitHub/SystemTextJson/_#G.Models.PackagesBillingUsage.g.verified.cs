//HintName: G.Models.PackagesBillingUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PackagesBillingUsage
    {
        /// <summary>
        /// Sum of the free and paid storage space (GB) for GitHuub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_gigabytes_bandwidth_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalGigabytesBandwidthUsed { get; set; }

        /// <summary>
        /// Total paid storage space (GB) for GitHuub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_paid_gigabytes_bandwidth_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPaidGigabytesBandwidthUsed { get; set; }

        /// <summary>
        /// Free storage space (GB) for GitHub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_gigabytes_bandwidth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IncludedGigabytesBandwidth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PackagesBillingUsage" /> class.
        /// </summary>
        /// <param name="totalGigabytesBandwidthUsed">
        /// Sum of the free and paid storage space (GB) for GitHuub Packages.
        /// </param>
        /// <param name="totalPaidGigabytesBandwidthUsed">
        /// Total paid storage space (GB) for GitHuub Packages.
        /// </param>
        /// <param name="includedGigabytesBandwidth">
        /// Free storage space (GB) for GitHub Packages.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PackagesBillingUsage(
            int totalGigabytesBandwidthUsed,
            int totalPaidGigabytesBandwidthUsed,
            int includedGigabytesBandwidth)
        {
            this.TotalGigabytesBandwidthUsed = totalGigabytesBandwidthUsed;
            this.TotalPaidGigabytesBandwidthUsed = totalPaidGigabytesBandwidthUsed;
            this.IncludedGigabytesBandwidth = includedGigabytesBandwidth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackagesBillingUsage" /> class.
        /// </summary>
        public PackagesBillingUsage()
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
        public static global::G.PackagesBillingUsage? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.PackagesBillingUsage),
                jsonSerializerContext) as global::G.PackagesBillingUsage;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PackagesBillingUsage? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.PackagesBillingUsage>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.PackagesBillingUsage?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.PackagesBillingUsage),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.PackagesBillingUsage;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PackagesBillingUsage?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.PackagesBillingUsage?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}