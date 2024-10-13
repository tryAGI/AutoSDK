//HintName: G.Models.WhereFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter search results using a where filter
    /// </summary>
    public sealed partial class WhereFilter
    {
        /// <summary>
        /// combine multiple where filters, requires 'And' or 'Or' operator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operands")]
        public global::System.Collections.Generic.IList<global::G.WhereFilter>? Operands { get; set; }

        /// <summary>
        /// operator to use<br/>
        /// Example: GreaterThanEqual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WhereFilterOperatorJsonConverter))]
        public global::G.WhereFilterOperator? Operator { get; set; }

        /// <summary>
        /// path to the property currently being filtered<br/>
        /// Example: [inCity, City, name]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public global::System.Collections.Generic.IList<string>? Path { get; set; }

        /// <summary>
        /// value as integer<br/>
        /// Example: 2000L
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueInt")]
        public long? ValueInt { get; set; }

        /// <summary>
        /// value as number/float<br/>
        /// Example: 3.14
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueNumber")]
        public double? ValueNumber { get; set; }

        /// <summary>
        /// value as boolean<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueBoolean")]
        public bool? ValueBoolean { get; set; }

        /// <summary>
        /// value as text (deprecated as of v1.19; alias for valueText)<br/>
        /// Example: my search term
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueString")]
        public string? ValueString { get; set; }

        /// <summary>
        /// value as text<br/>
        /// Example: my search term
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueText")]
        public string? ValueText { get; set; }

        /// <summary>
        /// value as date (as string)<br/>
        /// Example: TODO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueDate")]
        public string? ValueDate { get; set; }

        /// <summary>
        /// value as integer<br/>
        /// Example: [100, 200]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueIntArray")]
        public global::System.Collections.Generic.IList<long>? ValueIntArray { get; set; }

        /// <summary>
        /// value as number/float<br/>
        /// Example: [3.14]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueNumberArray")]
        public global::System.Collections.Generic.IList<double>? ValueNumberArray { get; set; }

        /// <summary>
        /// value as boolean<br/>
        /// Example: [true, false]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueBooleanArray")]
        public global::System.Collections.Generic.IList<bool>? ValueBooleanArray { get; set; }

        /// <summary>
        /// value as text (deprecated as of v1.19; alias for valueText)<br/>
        /// Example: [my search term]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueStringArray")]
        public global::System.Collections.Generic.IList<string>? ValueStringArray { get; set; }

        /// <summary>
        /// value as text<br/>
        /// Example: [my search term]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueTextArray")]
        public global::System.Collections.Generic.IList<string>? ValueTextArray { get; set; }

        /// <summary>
        /// value as date (as string)<br/>
        /// Example: TODO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueDateArray")]
        public global::System.Collections.Generic.IList<string>? ValueDateArray { get; set; }

        /// <summary>
        /// filter within a distance of a georange
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueGeoRange")]
        public global::G.WhereFilterGeoRange? ValueGeoRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.WhereFilter? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.WhereFilter),
                jsonSerializerContext) as global::G.WhereFilter;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WhereFilter? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.WhereFilter>(
                json,
                jsonSerializerOptions);
        }

    }
}