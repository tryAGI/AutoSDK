//HintName: G.Models.StringToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StringToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StringToolChoiceOptions Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StringToolChoice" /> class.
        /// </summary>
        /// <param name="value"></param>
        public StringToolChoice(
            global::G.StringToolChoiceOptions value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringToolChoice" /> class.
        /// </summary>
        public StringToolChoice()
        {
        }
    }
}