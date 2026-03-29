//HintName: G.Models.Score2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Score2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ValueType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<double?, global::System.DateTime?, string> Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Score2" /> class.
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="value"></param>
        public Score2(
            string valueType,
            global::G.AnyOf<double?, global::System.DateTime?, string> value)
        {
            this.ValueType = valueType ?? throw new global::System.ArgumentNullException(nameof(valueType));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Score2" /> class.
        /// </summary>
        public Score2()
        {
        }
    }
}