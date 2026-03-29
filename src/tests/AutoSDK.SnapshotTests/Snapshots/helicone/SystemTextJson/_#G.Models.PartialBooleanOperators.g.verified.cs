//HintName: G.Models.PartialBooleanOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialBooleanOperators
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equals")]
        public bool? EqualsValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialBooleanOperators" /> class.
        /// </summary>
        /// <param name="equalsValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialBooleanOperators(
            bool? equalsValue)
        {
            this.EqualsValue = equalsValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialBooleanOperators" /> class.
        /// </summary>
        public PartialBooleanOperators()
        {
        }
    }
}