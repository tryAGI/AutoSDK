//HintName: G.Models.RepositoryRulesetConditionsRepositoryPropertySpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for a targeting a repository property
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryPropertySpec
    {
        /// <summary>
        /// The name of the repository property to target
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The values to match for the repository property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PropertyValues { get; set; }

        /// <summary>
        /// The source of the repository property. Defaults to 'custom' if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRulesetConditionsRepositoryPropertySpecSourceJsonConverter))]
        public global::G.RepositoryRulesetConditionsRepositoryPropertySpecSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryPropertySpec" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the repository property to target
        /// </param>
        /// <param name="propertyValues">
        /// The values to match for the repository property
        /// </param>
        /// <param name="source">
        /// The source of the repository property. Defaults to 'custom' if not specified.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRulesetConditionsRepositoryPropertySpec(
            string name,
            global::System.Collections.Generic.IList<string> propertyValues,
            global::G.RepositoryRulesetConditionsRepositoryPropertySpecSource? source)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PropertyValues = propertyValues ?? throw new global::System.ArgumentNullException(nameof(propertyValues));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryPropertySpec" /> class.
        /// </summary>
        public RepositoryRulesetConditionsRepositoryPropertySpec()
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
        public static global::G.RepositoryRulesetConditionsRepositoryPropertySpec? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.RepositoryRulesetConditionsRepositoryPropertySpec),
                jsonSerializerContext) as global::G.RepositoryRulesetConditionsRepositoryPropertySpec;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RepositoryRulesetConditionsRepositoryPropertySpec? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRulesetConditionsRepositoryPropertySpec>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.RepositoryRulesetConditionsRepositoryPropertySpec?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.RepositoryRulesetConditionsRepositoryPropertySpec),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.RepositoryRulesetConditionsRepositoryPropertySpec;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RepositoryRulesetConditionsRepositoryPropertySpec?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.RepositoryRulesetConditionsRepositoryPropertySpec?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}