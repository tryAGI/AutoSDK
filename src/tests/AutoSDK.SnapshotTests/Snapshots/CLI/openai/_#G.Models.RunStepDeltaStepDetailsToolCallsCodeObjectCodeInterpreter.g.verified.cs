﻿//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The Code Interpreter tool call definition.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter
    {
        /// <summary>
        /// The input to the Code Interpreter tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// The outputs from the Code Interpreter tool call. Code Interpreter can output one or more items, including text (`logs`) or images (`image`). Each of these are represented by a different object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>? Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter" /> class.
        /// </summary>
        /// <param name="input">
        /// The input to the Code Interpreter tool call.
        /// </param>
        /// <param name="outputs">
        /// The outputs from the Code Interpreter tool call. Code Interpreter can output one or more items, including text (`logs`) or images (`image`). Each of these are represented by a different object type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter(
            string? input,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject, global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject>>? outputs)
        {
            this.Input = input;
            this.Outputs = outputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter()
        {
        }
    }
}