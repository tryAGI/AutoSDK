//HintName: G.Models.ConversationalFlowLayer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationalFlowLayer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_detection_model")]
        public string? TurnDetectionModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_taking_patience")]
        public global::G.ConversationalFlowLayerTurnTakingPatience? TurnTakingPatience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replica_interruptibility")]
        public global::G.ConversationalFlowLayerReplicaInterruptibility? ReplicaInterruptibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalFlowLayer" /> class.
        /// </summary>
        /// <param name="turnDetectionModel"></param>
        /// <param name="turnTakingPatience"></param>
        /// <param name="replicaInterruptibility"></param>
        public ConversationalFlowLayer(
            string? turnDetectionModel,
            global::G.ConversationalFlowLayerTurnTakingPatience? turnTakingPatience,
            global::G.ConversationalFlowLayerReplicaInterruptibility? replicaInterruptibility)
        {
            this.TurnDetectionModel = turnDetectionModel;
            this.TurnTakingPatience = turnTakingPatience;
            this.ReplicaInterruptibility = replicaInterruptibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationalFlowLayer" /> class.
        /// </summary>
        public ConversationalFlowLayer()
        {
        }
    }
}