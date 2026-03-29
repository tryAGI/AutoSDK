//HintName: G.Models.UtteranceToolCallAccuracy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UtteranceToolCallAccuracy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missed_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MissedToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incorrectly_added_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> IncorrectlyAddedToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wrong_arguments_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> WrongArgumentsToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceToolCallAccuracy" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="missedToolCalls"></param>
        /// <param name="incorrectlyAddedToolCalls"></param>
        /// <param name="wrongArgumentsToolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceToolCallAccuracy(
            double responseId,
            global::System.Collections.Generic.IList<string> missedToolCalls,
            global::System.Collections.Generic.IList<string> incorrectlyAddedToolCalls,
            global::System.Collections.Generic.IList<string> wrongArgumentsToolCalls)
        {
            this.ResponseId = responseId;
            this.MissedToolCalls = missedToolCalls ?? throw new global::System.ArgumentNullException(nameof(missedToolCalls));
            this.IncorrectlyAddedToolCalls = incorrectlyAddedToolCalls ?? throw new global::System.ArgumentNullException(nameof(incorrectlyAddedToolCalls));
            this.WrongArgumentsToolCalls = wrongArgumentsToolCalls ?? throw new global::System.ArgumentNullException(nameof(wrongArgumentsToolCalls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceToolCallAccuracy" /> class.
        /// </summary>
        public UtteranceToolCallAccuracy()
        {
        }
    }
}