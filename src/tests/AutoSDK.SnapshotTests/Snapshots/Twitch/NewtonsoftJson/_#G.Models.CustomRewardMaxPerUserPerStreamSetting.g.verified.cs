//HintName: G.Models.CustomRewardMaxPerUserPerStreamSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per user per live stream.
    /// </summary>
    public sealed partial class CustomRewardMaxPerUserPerStreamSetting
    {
        /// <summary>
        /// A Boolean value that determines whether the reward applies a limit on the number of redemptions allowed per user per live stream. Is **true** if the reward applies a limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsEnabled { get; set; } = default!;

        /// <summary>
        /// The maximum number of redemptions allowed per user per live stream.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_per_user_per_stream", Required = global::Newtonsoft.Json.Required.Always)]
        public long MaxPerUserPerStream { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardMaxPerUserPerStreamSetting" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// A Boolean value that determines whether the reward applies a limit on the number of redemptions allowed per user per live stream. Is **true** if the reward applies a limit.
        /// </param>
        /// <param name="maxPerUserPerStream">
        /// The maximum number of redemptions allowed per user per live stream.
        /// </param>
        public CustomRewardMaxPerUserPerStreamSetting(
            bool isEnabled,
            long maxPerUserPerStream)
        {
            this.IsEnabled = isEnabled;
            this.MaxPerUserPerStream = maxPerUserPerStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardMaxPerUserPerStreamSetting" /> class.
        /// </summary>
        public CustomRewardMaxPerUserPerStreamSetting()
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
        public static global::G.CustomRewardMaxPerUserPerStreamSetting? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CustomRewardMaxPerUserPerStreamSetting>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CustomRewardMaxPerUserPerStreamSetting?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CustomRewardMaxPerUserPerStreamSetting?>(serializer.Deserialize<global::G.CustomRewardMaxPerUserPerStreamSetting>(jsonReader));
        }

    }
}