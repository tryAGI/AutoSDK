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
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StringToolChoiceOptionsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StringToolChoiceOptions Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StringToolChoice" /> class.
        /// </summary>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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