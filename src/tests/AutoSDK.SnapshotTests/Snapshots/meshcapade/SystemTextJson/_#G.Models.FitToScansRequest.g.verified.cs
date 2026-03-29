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
        [global::System.Text.Json.Serialization.JsonPropertyName("initPose")]
        public string? InitPose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputUnits")]
        public string? InputUnits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lookAxis")]
        public string? LookAxis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upAxis")]
        public string? UpAxis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FitToScansRequest" /> class.
        /// </summary>
        /// <param name="initPose"></param>
        /// <param name="inputUnits"></param>
        /// <param name="lookAxis"></param>
        /// <param name="upAxis"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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