//HintName: G.Models.ConstantSchemaOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConstantSchemaOverride
    {
        /// <summary>
        /// Default Value: constant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The constant value to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, int?, double?, bool?> ConstantValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantSchemaOverride" /> class.
        /// </summary>
        /// <param name="source">
        /// Default Value: constant
        /// </param>
        /// <param name="constantValue">
        /// The constant value to use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConstantSchemaOverride(
            global::G.AnyOf<string, int?, double?, bool?> constantValue,
            string? source)
        {
            this.ConstantValue = constantValue;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantSchemaOverride" /> class.
        /// </summary>
        public ConstantSchemaOverride()
        {
        }
    }
}