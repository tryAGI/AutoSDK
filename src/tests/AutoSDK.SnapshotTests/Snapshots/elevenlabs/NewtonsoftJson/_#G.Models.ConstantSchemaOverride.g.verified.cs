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
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The constant value to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("constant_value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, int?, double?, bool?> ConstantValue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantSchemaOverride" /> class.
        /// </summary>
        /// <param name="constantValue">
        /// The constant value to use
        /// </param>
        /// <param name="source">
        /// Default Value: constant
        /// </param>
        public ConstantSchemaOverride(
            global::G.AnyOf<string, int?, double?, bool?> constantValue,
            string? source)
        {
            this.Source = source;
            this.ConstantValue = constantValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantSchemaOverride" /> class.
        /// </summary>
        public ConstantSchemaOverride()
        {
        }
    }
}