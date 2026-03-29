//HintName: G.Models.MotionBlendMotion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MotionBlendMotion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("motionId")]
        public string? MotionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MotionBlendMotion" /> class.
        /// </summary>
        /// <param name="motionId"></param>
        public MotionBlendMotion(
            string? motionId)
        {
            this.MotionId = motionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MotionBlendMotion" /> class.
        /// </summary>
        public MotionBlendMotion()
        {
        }
    }
}