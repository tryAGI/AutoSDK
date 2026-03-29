//HintName: G.Models.AnimationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnimationRequest
    {
        /// <summary>
        /// ID of completed rigging task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rig_task_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RigTaskId { get; set; } = default!;

        /// <summary>
        /// Animation action identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ActionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_process")]
        public global::G.AnimationPostProcess? PostProcess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationRequest" /> class.
        /// </summary>
        /// <param name="rigTaskId">
        /// ID of completed rigging task
        /// </param>
        /// <param name="actionId">
        /// Animation action identifier
        /// </param>
        /// <param name="postProcess"></param>
        public AnimationRequest(
            string rigTaskId,
            int actionId,
            global::G.AnimationPostProcess? postProcess)
        {
            this.RigTaskId = rigTaskId ?? throw new global::System.ArgumentNullException(nameof(rigTaskId));
            this.ActionId = actionId;
            this.PostProcess = postProcess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationRequest" /> class.
        /// </summary>
        public AnimationRequest()
        {
        }
    }
}