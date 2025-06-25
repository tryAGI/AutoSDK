﻿//HintName: G.Models.RunStepDeltaObjectDelta.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The delta containing the fields that have changed on the run step.
    /// </summary>
    public sealed partial class RunStepDeltaObjectDelta
    {
        /// <summary>
        /// The details of the run step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.RunStepDeltaStepDetailsMessageCreationObject, global::G.RunStepDeltaStepDetailsToolCallsObject>))]
        public global::G.OneOf<global::G.RunStepDeltaStepDetailsMessageCreationObject, global::G.RunStepDeltaStepDetailsToolCallsObject>? StepDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaObjectDelta" /> class.
        /// </summary>
        /// <param name="stepDetails">
        /// The details of the run step.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDeltaObjectDelta(
            global::G.OneOf<global::G.RunStepDeltaStepDetailsMessageCreationObject, global::G.RunStepDeltaStepDetailsToolCallsObject>? stepDetails)
        {
            this.StepDetails = stepDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaObjectDelta" /> class.
        /// </summary>
        public RunStepDeltaObjectDelta()
        {
        }
    }
}