//HintName: G.Models.FitToScansRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FitToScansRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initPose")]
        public string? InitPose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputUnits")]
        public string? InputUnits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lookAxis")]
        public string? LookAxis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upAxis")]
        public string? UpAxis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FitToScansRequest" /> class.
        /// </summary>
        /// <param name="initPose"></param>
        /// <param name="inputUnits"></param>
        /// <param name="lookAxis"></param>
        /// <param name="upAxis"></param>
        public FitToScansRequest(
            string? initPose,
            string? inputUnits,
            string? lookAxis,
            string? upAxis)
        {
            this.InitPose = initPose;
            this.InputUnits = inputUnits;
            this.LookAxis = lookAxis;
            this.UpAxis = upAxis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FitToScansRequest" /> class.
        /// </summary>
        public FitToScansRequest()
        {
        }
    }
}