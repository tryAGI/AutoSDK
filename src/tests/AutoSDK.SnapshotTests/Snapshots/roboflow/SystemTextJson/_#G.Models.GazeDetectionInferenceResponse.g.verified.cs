//HintName: G.Models.GazeDetectionInferenceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for gaze detection inference.<br/>
    /// Attributes:<br/>
    ///     predictions (List[inference.core.entities.responses.gaze.GazeDetectionPrediction]): List of gaze detection predictions.<br/>
    ///     time (float): The processing time (second).
    /// </summary>
    public sealed partial class GazeDetectionInferenceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GazeDetectionPrediction> Predictions { get; set; }

        /// <summary>
        /// The processing time (second)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// The face detection time (second)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_face_det")]
        public double? TimeFaceDet { get; set; }

        /// <summary>
        /// The gaze detection time (second)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_gaze_det")]
        public double? TimeGazeDet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GazeDetectionInferenceResponse" /> class.
        /// </summary>
        /// <param name="predictions"></param>
        /// <param name="time">
        /// The processing time (second)
        /// </param>
        /// <param name="timeFaceDet">
        /// The face detection time (second)
        /// </param>
        /// <param name="timeGazeDet">
        /// The gaze detection time (second)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GazeDetectionInferenceResponse(
            global::System.Collections.Generic.IList<global::G.GazeDetectionPrediction> predictions,
            double time,
            double? timeFaceDet,
            double? timeGazeDet)
        {
            this.Predictions = predictions ?? throw new global::System.ArgumentNullException(nameof(predictions));
            this.Time = time;
            this.TimeFaceDet = timeFaceDet;
            this.TimeGazeDet = timeGazeDet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GazeDetectionInferenceResponse" /> class.
        /// </summary>
        public GazeDetectionInferenceResponse()
        {
        }
    }
}