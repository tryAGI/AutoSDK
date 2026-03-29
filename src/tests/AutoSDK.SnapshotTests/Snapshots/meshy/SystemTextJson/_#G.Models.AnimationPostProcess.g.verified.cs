//HintName: G.Models.AnimationPostProcess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnimationPostProcess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnimationPostProcessOperationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnimationPostProcessOperationType OperationType { get; set; }

        /// <summary>
        /// Target FPS (only for change_fps)<br/>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public int? Fps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationPostProcess" /> class.
        /// </summary>
        /// <param name="operationType"></param>
        /// <param name="fps">
        /// Target FPS (only for change_fps)<br/>
        /// Default Value: 30
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnimationPostProcess(
            global::G.AnimationPostProcessOperationType operationType,
            int? fps)
        {
            this.OperationType = operationType;
            this.Fps = fps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationPostProcess" /> class.
        /// </summary>
        public AnimationPostProcess()
        {
        }
    }
}