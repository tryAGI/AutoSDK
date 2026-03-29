//HintName: G.Models.PickTalksConfigMotionFactorOrAlignExpandFactorOrStitch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickTalksConfigMotionFactorOrAlignExpandFactorOrStitch
    {
        /// <summary>
        /// Stitch back the animated result to the original image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stitch")]
        public bool? Stitch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickTalksConfigMotionFactorOrAlignExpandFactorOrStitch" /> class.
        /// </summary>
        /// <param name="stitch">
        /// Stitch back the animated result to the original image
        /// </param>
        public PickTalksConfigMotionFactorOrAlignExpandFactorOrStitch(
            bool? stitch)
        {
            this.Stitch = stitch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickTalksConfigMotionFactorOrAlignExpandFactorOrStitch" /> class.
        /// </summary>
        public PickTalksConfigMotionFactorOrAlignExpandFactorOrStitch()
        {
        }
    }
}