//HintName: G.Models.LiteralOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LiteralOverride
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        public string? DynamicVariable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("constant_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>))]
        public global::G.AnyOf<string, int?, double?, bool?, object>? ConstantValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralOverride" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="dynamicVariable"></param>
        /// <param name="constantValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteralOverride(
            string? description,
            string? dynamicVariable,
            global::G.AnyOf<string, int?, double?, bool?, object>? constantValue)
        {
            this.Description = description;
            this.DynamicVariable = dynamicVariable;
            this.ConstantValue = constantValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralOverride" /> class.
        /// </summary>
        public LiteralOverride()
        {
        }
    }
}