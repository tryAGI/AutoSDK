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
        [global::System.Text.Json.Serialization.JsonPropertyName("rig_task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RigTaskId { get; set; }

        /// <summary>
        /// Animation action identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_process")]
        public global::G.AnimationPostProcess? PostProcess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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