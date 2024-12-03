//HintName: G.Models.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorTypeJsonConverter))]
        public global::G.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator(
            global::G.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator()
        {
        }
    }
}