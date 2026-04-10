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
        [global::Newtonsoft.Json.JsonProperty("operation_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AnimationPostProcessOperationTypeJsonConverter))]
        public global::G.AnimationPostProcessOperationType OperationType { get; set; } = default!;

        /// <summary>
        /// Target FPS (only for change_fps)<br/>
        /// Default Value: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fps")]
        public int? Fps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationPostProcess" /> class.
        /// </summary>
        /// <param name="operationType"></param>
        /// <param name="fps">
        /// Target FPS (only for change_fps)<br/>
        /// Default Value: 30
        /// </param>
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