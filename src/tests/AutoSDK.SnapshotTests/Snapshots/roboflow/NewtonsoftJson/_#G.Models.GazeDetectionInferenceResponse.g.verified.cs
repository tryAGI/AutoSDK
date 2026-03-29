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
        [global::Newtonsoft.Json.JsonProperty("predictions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GazeDetectionPrediction> Predictions { get; set; } = default!;

        /// <summary>
        /// The processing time (second)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Time { get; set; } = default!;

        /// <summary>
        /// The face detection time (second)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_face_det")]
        public double? TimeFaceDet { get; set; }

        /// <summary>
        /// The gaze detection time (second)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_gaze_det")]
        public double? TimeGazeDet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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