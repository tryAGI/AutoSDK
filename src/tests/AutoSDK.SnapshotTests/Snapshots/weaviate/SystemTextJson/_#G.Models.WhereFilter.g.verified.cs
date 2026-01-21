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
        /// <example>GreaterThanEqual</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WhereFilterOperatorJsonConverter))]
        public global::G.WhereFilterOperator? Operator { get; set; }

        /// <summary>
        /// path to the property currently being filtered<br/>
        /// Example: [inCity, City, name]
        /// </summary>
        /// <example>[inCity, City, name]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public global::System.Collections.Generic.IList<string>? Path { get; set; }

        /// <summary>
        /// value as integer<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueInt")]
        public long? ValueInt { get; set; }

        /// <summary>
        /// value as number/float<br/>
        /// Example: 3.14
        /// </summary>
        /// <example>3.14</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueNumber")]
        public double? ValueNumber { get; set; }

        /// <summary>
        /// value as boolean<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueBoolean")]
        public bool? ValueBoolean { get; set; }

        /// <summary>
        /// value as text (deprecated as of v1.19; alias for valueText)<br/>
        /// Example: my search term
        /// </summary>
        /// <example>my search term</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueString")]
        public string? ValueString { get; set; }

        /// <summary>
        /// value as text<br/>
        /// Example: my search term
        /// </summary>
        /// <example>my search term</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueText")]
        public string? ValueText { get; set; }

        /// <summary>
        /// value as date (as string)<br/>
        /// Example: TODO
        /// </summary>
        /// <example>TODO</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueDate")]
        public string? ValueDate { get; set; }

        /// <summary>
        /// value as integer<br/>
        /// Example: [100, 200]
        /// </summary>
        /// <example>[100, 200]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueIntArray")]
        public global::System.Collections.Generic.IList<long>? ValueIntArray { get; set; }

        /// <summary>
        /// value as number/float<br/>
        /// Example: [3.14]
        /// </summary>
        /// <example>[3.14]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueNumberArray")]
        public global::System.Collections.Generic.IList<double>? ValueNumberArray { get; set; }

        /// <summary>
        /// value as boolean<br/>
        /// Example: [true, false]
        /// </summary>
        /// <example>[true, false]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueBooleanArray")]
        public global::System.Collections.Generic.IList<bool>? ValueBooleanArray { get; set; }

        /// <summary>
        /// value as text (deprecated as of v1.19; alias for valueText)<br/>
        /// Example: [my search term]
        /// </summary>
        /// <example>[my search term]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueStringArray")]
        public global::System.Collections.Generic.IList<string>? ValueStringArray { get; set; }

        /// <summary>
        /// value as text<br/>
        /// Example: [my search term]
        /// </summary>
        /// <example>[my search term]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueTextArray")]
        public global::System.Collections.Generic.IList<string>? ValueTextArray { get; set; }

        /// <summary>
        /// value as date (as string)<br/>
        /// Example: TODO
        /// </summary>
        /// <example>TODO</example>
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
        /// Example: 2000
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
    }
}