//HintName: G.Models.ComparisonFilter.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A filter used to compare a specified attribute key to a given value using a defined comparison operation.
    /// </summary>
    public sealed partial class ComparisonFilter
    {
        /// <summary>
        /// The key to compare against the value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Specifies the comparison operator: `eq`, `ne`, `gt`, `gte`, `lt`, `lte`.<br/>
        /// - `eq`: equals<br/>
        /// - `ne`: not equal<br/>
        /// - `gt`: greater than<br/>
        /// - `gte`: greater than or equal<br/>
        /// - `lt`: less than<br/>
        /// - `lte`: less than or equal<br/>
        /// Default Value: eq
        /// </summary>
        /// <default>global::G.ComparisonFilterType.Eq</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComparisonFilterTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ComparisonFilterType Type { get; set; } = global::G.ComparisonFilterType.Eq;

        /// <summary>
        /// The value to compare against the attribute key; supports string, number, or boolean types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, double?, bool?> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComparisonFilter" /> class.
        /// </summary>
        /// <param name="key">
        /// The key to compare against the value.
        /// </param>
        /// <param name="type">
        /// Specifies the comparison operator: `eq`, `ne`, `gt`, `gte`, `lt`, `lte`.<br/>
        /// - `eq`: equals<br/>
        /// - `ne`: not equal<br/>
        /// - `gt`: greater than<br/>
        /// - `gte`: greater than or equal<br/>
        /// - `lt`: less than<br/>
        /// - `lte`: less than or equal<br/>
        /// Default Value: eq
        /// </param>
        /// <param name="value">
        /// The value to compare against the attribute key; supports string, number, or boolean types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComparisonFilter(
            string key,
            global::G.ComparisonFilterType type,
            global::G.OneOf<string, double?, bool?> value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComparisonFilter" /> class.
        /// </summary>
        public ComparisonFilter()
        {
        }
    }
}