//HintName: G.Models.PipelineContainerState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineContainerState
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PipelineStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PipelineState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_run")]
        public string? CurrentRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineContainerState" /> class.
        /// </summary>
        /// <param name="state">
        /// An enumeration.
        /// </param>
        /// <param name="message"></param>
        /// <param name="currentRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineContainerState(
            global::G.PipelineState state,
            string? message,
            string? currentRun)
        {
            this.State = state;
            this.Message = message;
            this.CurrentRun = currentRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineContainerState" /> class.
        /// </summary>
        public PipelineContainerState()
        {
        }
    }
}