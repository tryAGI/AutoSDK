//HintName: G.Models.ColorPaletteMember.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A member of a color palette.
    /// </summary>
    public sealed partial class ColorPaletteMember
    {
        /// <summary>
        /// The hexadecimal representation of the color with an optional chosen weight<br/>
        /// Example: #FFFFFF
        /// </summary>
        /// <example>#FFFFFF</example>
        [global::Newtonsoft.Json.JsonProperty("color_hex", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColorHex { get; set; } = default!;

        /// <summary>
        /// The weight of the color in the color palette.<br/>
        /// Example: 0.25
        /// </summary>
        /// <example>0.25</example>
        [global::Newtonsoft.Json.JsonProperty("color_weight", Required = global::Newtonsoft.Json.Required.Always)]
        public double ColorWeight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteMember" /> class.
        /// </summary>
        /// <param name="colorHex">
        /// The hexadecimal representation of the color with an optional chosen weight<br/>
        /// Example: #FFFFFF
        /// </param>
        /// <param name="colorWeight">
        /// The weight of the color in the color palette.<br/>
        /// Example: 0.25
        /// </param>
        public ColorPaletteMember(
            string colorHex,
            double colorWeight)
        {
            this.ColorHex = colorHex ?? throw new global::System.ArgumentNullException(nameof(colorHex));
            this.ColorWeight = colorWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteMember" /> class.
        /// </summary>
        public ColorPaletteMember()
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
        public static global::G.ColorPaletteMember? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ColorPaletteMember>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ColorPaletteMember?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ColorPaletteMember?>(serializer.Deserialize<global::G.ColorPaletteMember>(jsonReader));
        }

    }
}