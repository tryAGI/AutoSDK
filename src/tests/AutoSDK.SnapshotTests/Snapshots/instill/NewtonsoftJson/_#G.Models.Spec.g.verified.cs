//HintName: G.Models.Spec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Spec represents a specification data model.
    /// </summary>
    public sealed partial class Spec
    {
        /// <summary>
        /// Component specification.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("componentSpecification", Required = global::Newtonsoft.Json.Required.Always)]
        public object ComponentSpecification { get; set; } = default!;

        /// <summary>
        /// Data specifications.<br/>
        /// The key represents the task, and the value is the corresponding data_specification.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataSpecifications", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.DataSpecification> DataSpecifications { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Spec" /> class.
        /// </summary>
        /// <param name="componentSpecification">
        /// Component specification.
        /// </param>
        /// <param name="dataSpecifications">
        /// Data specifications.<br/>
        /// The key represents the task, and the value is the corresponding data_specification.
        /// </param>
        public Spec(
            object componentSpecification,
            global::System.Collections.Generic.Dictionary<string, global::G.DataSpecification> dataSpecifications)
        {
            this.ComponentSpecification = componentSpecification ?? throw new global::System.ArgumentNullException(nameof(componentSpecification));
            this.DataSpecifications = dataSpecifications ?? throw new global::System.ArgumentNullException(nameof(dataSpecifications));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Spec" /> class.
        /// </summary>
        public Spec()
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
        public static global::G.Spec? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Spec>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Spec?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Spec?>(serializer.Deserialize<global::G.Spec>(jsonReader));
        }

    }
}