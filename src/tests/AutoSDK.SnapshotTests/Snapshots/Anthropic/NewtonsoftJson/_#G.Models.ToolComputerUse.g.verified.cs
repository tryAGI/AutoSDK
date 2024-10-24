//HintName: G.Models.ToolComputerUse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that uses a mouse and keyboard to interact with a computer, and take screenshots.
    /// </summary>
    public sealed partial class ToolComputerUse
    {
        /// <summary>
        /// The type of tool.<br/>
        /// Default Value: computer_20241022
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; } = "computer_20241022";

        /// <summary>
        /// The name of the tool.<br/>
        /// Default Value: computer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; } = "computer";

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// The width of the display in pixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_width_px", Required = global::Newtonsoft.Json.Required.Always)]
        public int DisplayWidthPx { get; set; } = default!;

        /// <summary>
        /// The height of the display in pixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_height_px", Required = global::Newtonsoft.Json.Required.Always)]
        public int DisplayHeightPx { get; set; } = default!;

        /// <summary>
        /// The number of the display to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_number")]
        public int? DisplayNumber { get; set; }

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
        public static global::G.ToolComputerUse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ToolComputerUse>(
                json,
                jsonSerializerOptions);
        }

    }
}