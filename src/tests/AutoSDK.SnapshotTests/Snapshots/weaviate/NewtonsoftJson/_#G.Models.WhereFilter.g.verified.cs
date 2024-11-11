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
        [global::Newtonsoft.Json.JsonProperty("operands")]
        public global::System.Collections.Generic.IList<global::G.WhereFilter>? Operands { get; set; }

        /// <summary>
        /// operator to use<br/>
        /// Example: GreaterThanEqual
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator")]
        public global::G.WhereFilterOperator? Operator { get; set; }

        /// <summary>
        /// path to the property currently being filtered<br/>
        /// Example: [inCity, City, name]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public global::System.Collections.Generic.IList<string>? Path { get; set; }

        /// <summary>
        /// value as integer<br/>
        /// Example: 2000L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueInt")]
        public long? ValueInt { get; set; }

        /// <summary>
        /// value as number/float<br/>
        /// Example: 3.14
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueNumber")]
        public double? ValueNumber { get; set; }

        /// <summary>
        /// value as boolean<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueBoolean")]
        public bool? ValueBoolean { get; set; }

        /// <summary>
        /// value as text (deprecated as of v1.19; alias for valueText)<br/>
        /// Example: my search term
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueString")]
        public string? ValueString { get; set; }

        /// <summary>
        /// value as text<br/>
        /// Example: my search term
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueText")]
        public string? ValueText { get; set; }

        /// <summary>
        /// value as date (as string)<br/>
        /// Example: TODO
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueDate")]
        public string? ValueDate { get; set; }

        /// <summary>
        /// value as integer<br/>
        /// Example: [100, 200]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueIntArray")]
        public global::System.Collections.Generic.IList<long>? ValueIntArray { get; set; }

        /// <summary>
        /// value as number/float<br/>
        /// Example: [3.14]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueNumberArray")]
        public global::System.Collections.Generic.IList<double>? ValueNumberArray { get; set; }

        /// <summary>
        /// value as boolean<br/>
        /// Example: [true, false]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueBooleanArray")]
        public global::System.Collections.Generic.IList<bool>? ValueBooleanArray { get; set; }

        /// <summary>
        /// value as text (deprecated as of v1.19; alias for valueText)<br/>
        /// Example: [my search term]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueStringArray")]
        public global::System.Collections.Generic.IList<string>? ValueStringArray { get; set; }

        /// <summary>
        /// value as text<br/>
        /// Example: [my search term]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueTextArray")]
        public global::System.Collections.Generic.IList<string>? ValueTextArray { get; set; }

        /// <summary>
        /// value as date (as string)<br/>
        /// Example: TODO
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueDateArray")]
        public global::System.Collections.Generic.IList<string>? ValueDateArray { get; set; }

        /// <summary>
        /// filter within a distance of a georange
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueGeoRange")]
        public global::G.WhereFilterGeoRange? ValueGeoRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereFilter" /> class.
        /// </summary>
        /// <param name="operands">
        /// combine multiple where filters, requires 'And' or 'Or' operator
        /// </param>
        /// <param name="operator">
        /// operator to use<br/>
        /// Example: GreaterThanEqual
        /// </param>
        /// <param name="path">
        /// path to the property currently being filtered<br/>
        /// Example: [inCity, City, name]
        /// </param>
        /// <param name="valueInt">
        /// value as integer<br/>
        /// Example: 2000L
        /// </param>
        /// <param name="valueNumber">
        /// value as number/float<br/>
        /// Example: 3.14
        /// </param>
        /// <param name="valueBoolean">
        /// value as boolean<br/>
        /// Example: false
        /// </param>
        /// <param name="valueString">
        /// value as text (deprecated as of v1.19; alias for valueText)<br/>
        /// Example: my search term
        /// </param>
        /// <param name="valueText">
        /// value as text<br/>
        /// Example: my search term
        /// </param>
        /// <param name="valueDate">
        /// value as date (as string)<br/>
        /// Example: TODO
        /// </param>
        /// <param name="valueIntArray">
        /// value as integer<br/>
        /// Example: [100, 200]
        /// </param>
        /// <param name="valueNumberArray">
        /// value as number/float<br/>
        /// Example: [3.14]
        /// </param>
        /// <param name="valueBooleanArray">
        /// value as boolean<br/>
        /// Example: [true, false]
        /// </param>
        /// <param name="valueStringArray">
        /// value as text (deprecated as of v1.19; alias for valueText)<br/>
        /// Example: [my search term]
        /// </param>
        /// <param name="valueTextArray">
        /// value as text<br/>
        /// Example: [my search term]
        /// </param>
        /// <param name="valueDateArray">
        /// value as date (as string)<br/>
        /// Example: TODO
        /// </param>
        /// <param name="valueGeoRange">
        /// filter within a distance of a georange
        /// </param>
        public WhereFilter(
            global::System.Collections.Generic.IList<global::G.WhereFilter>? operands,
            global::G.WhereFilterOperator? @operator,
            global::System.Collections.Generic.IList<string>? path,
            long? valueInt,
            double? valueNumber,
            bool? valueBoolean,
            string? valueString,
            string? valueText,
            string? valueDate,
            global::System.Collections.Generic.IList<long>? valueIntArray,
            global::System.Collections.Generic.IList<double>? valueNumberArray,
            global::System.Collections.Generic.IList<bool>? valueBooleanArray,
            global::System.Collections.Generic.IList<string>? valueStringArray,
            global::System.Collections.Generic.IList<string>? valueTextArray,
            global::System.Collections.Generic.IList<string>? valueDateArray,
            global::G.WhereFilterGeoRange? valueGeoRange)
        {
            this.Operands = operands;
            this.Operator = @operator;
            this.Path = path;
            this.ValueInt = valueInt;
            this.ValueNumber = valueNumber;
            this.ValueBoolean = valueBoolean;
            this.ValueString = valueString;
            this.ValueText = valueText;
            this.ValueDate = valueDate;
            this.ValueIntArray = valueIntArray;
            this.ValueNumberArray = valueNumberArray;
            this.ValueBooleanArray = valueBooleanArray;
            this.ValueStringArray = valueStringArray;
            this.ValueTextArray = valueTextArray;
            this.ValueDateArray = valueDateArray;
            this.ValueGeoRange = valueGeoRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereFilter" /> class.
        /// </summary>
        public WhereFilter()
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
        public static global::G.WhereFilter? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WhereFilter>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WhereFilter?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WhereFilter?>(serializer.Deserialize<global::G.WhereFilter>(jsonReader));
        }

    }
}