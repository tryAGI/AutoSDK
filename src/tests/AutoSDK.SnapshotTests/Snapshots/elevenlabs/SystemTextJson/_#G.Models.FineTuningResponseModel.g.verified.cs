//HintName: G.Models.FineTuningResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuningResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_allowed_to_fine_tune")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAllowedToFineTune { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.FineTuningResponseModelState2> State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_failures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> VerificationFailures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_attempts_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VerificationAttemptsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_verification_requested")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ManualVerificationRequested { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::System.Collections.Generic.Dictionary<string, double>? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::System.Collections.Generic.Dictionary<string, string>? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_duration_seconds")]
        public double? DatasetDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_attempts")]
        public global::System.Collections.Generic.IList<global::G.VerificationAttemptResponseModel>? VerificationAttempts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slice_ids")]
        public global::System.Collections.Generic.IList<string>? SliceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_verification")]
        public global::G.ManualVerificationResponseModel? ManualVerification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningResponseModel" /> class.
        /// </summary>
        /// <param name="isAllowedToFineTune"></param>
        /// <param name="state"></param>
        /// <param name="verificationFailures"></param>
        /// <param name="verificationAttemptsCount"></param>
        /// <param name="manualVerificationRequested"></param>
        /// <param name="language"></param>
        /// <param name="progress"></param>
        /// <param name="message"></param>
        /// <param name="datasetDurationSeconds"></param>
        /// <param name="verificationAttempts"></param>
        /// <param name="sliceIds"></param>
        /// <param name="manualVerification"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FineTuningResponseModel(
            bool isAllowedToFineTune,
            global::System.Collections.Generic.Dictionary<string, global::G.FineTuningResponseModelState2> state,
            global::System.Collections.Generic.IList<string> verificationFailures,
            int verificationAttemptsCount,
            bool manualVerificationRequested,
            string? language,
            global::System.Collections.Generic.Dictionary<string, double>? progress,
            global::System.Collections.Generic.Dictionary<string, string>? message,
            double? datasetDurationSeconds,
            global::System.Collections.Generic.IList<global::G.VerificationAttemptResponseModel>? verificationAttempts,
            global::System.Collections.Generic.IList<string>? sliceIds,
            global::G.ManualVerificationResponseModel? manualVerification)
        {
            this.IsAllowedToFineTune = isAllowedToFineTune;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.VerificationFailures = verificationFailures ?? throw new global::System.ArgumentNullException(nameof(verificationFailures));
            this.VerificationAttemptsCount = verificationAttemptsCount;
            this.ManualVerificationRequested = manualVerificationRequested;
            this.Language = language;
            this.Progress = progress;
            this.Message = message;
            this.DatasetDurationSeconds = datasetDurationSeconds;
            this.VerificationAttempts = verificationAttempts;
            this.SliceIds = sliceIds;
            this.ManualVerification = manualVerification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningResponseModel" /> class.
        /// </summary>
        public FineTuningResponseModel()
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
        public static global::G.FineTuningResponseModel? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.FineTuningResponseModel),
                jsonSerializerContext) as global::G.FineTuningResponseModel;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.FineTuningResponseModel? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.FineTuningResponseModel>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.FineTuningResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.FineTuningResponseModel),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.FineTuningResponseModel;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.FineTuningResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.FineTuningResponseModel?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}