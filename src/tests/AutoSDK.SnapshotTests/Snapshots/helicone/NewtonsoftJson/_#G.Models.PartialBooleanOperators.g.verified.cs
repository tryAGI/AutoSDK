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
        [global::Newtonsoft.Json.JsonProperty("equals")]
        public bool? EqualsValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialBooleanOperators" /> class.
        /// </summary>
        /// <param name="equalsValue"></param>
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