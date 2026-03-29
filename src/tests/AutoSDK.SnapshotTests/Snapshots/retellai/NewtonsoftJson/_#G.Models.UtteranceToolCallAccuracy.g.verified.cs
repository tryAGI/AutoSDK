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
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double ResponseId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("missed_tool_calls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> MissedToolCalls { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("incorrectly_added_tool_calls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> IncorrectlyAddedToolCalls { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wrong_arguments_tool_calls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> WrongArgumentsToolCalls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceToolCallAccuracy" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="missedToolCalls"></param>
        /// <param name="incorrectlyAddedToolCalls"></param>
        /// <param name="wrongArgumentsToolCalls"></param>
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