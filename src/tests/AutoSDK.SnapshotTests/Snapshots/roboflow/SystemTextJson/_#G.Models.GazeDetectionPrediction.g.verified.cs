//HintName: G.Models.GazeDetectionPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gaze Detection prediction.<br/>
    /// Attributes:<br/>
    ///     face (inference.core.entities.responses.inference.FaceDetectionPrediction): The face prediction.<br/>
    ///     yaw (float): Yaw (radian) of the detected face.<br/>
    ///     pitch (float): Pitch (radian) of the detected face.
    /// </summary>
    public sealed partial class GazeDetectionPrediction
    {
        /// <summary>
        /// Face Detection prediction.<br/>
        /// Attributes:<br/>
        ///     class_name (str): fixed value "face".<br/>
        ///     landmarks (Union[List[inference.core.entities.responses.inference.Point], List[inference.core.entities.responses.inference.Point3D]]): The detected face landmarks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FaceDetectionPrediction Face { get; set; }

        /// <summary>
        /// Yaw (radian) of the detected face
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yaw")]
        public double? Yaw { get; set; }

        /// <summary>
        /// Pitch (radian) of the detected face
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public double? Pitch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GazeDetectionPrediction" /> class.
        /// </summary>
        /// <param name="face">
        /// Face Detection prediction.<br/>
        /// Attributes:<br/>
        ///     class_name (str): fixed value "face".<br/>
        ///     landmarks (Union[List[inference.core.entities.responses.inference.Point], List[inference.core.entities.responses.inference.Point3D]]): The detected face landmarks.
        /// </param>
        /// <param name="yaw">
        /// Yaw (radian) of the detected face
        /// </param>
        /// <param name="pitch">
        /// Pitch (radian) of the detected face
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GazeDetectionPrediction(
            global::G.FaceDetectionPrediction face,
            double? yaw,
            double? pitch)
        {
            this.Face = face ?? throw new global::System.ArgumentNullException(nameof(face));
            this.Yaw = yaw;
            this.Pitch = pitch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GazeDetectionPrediction" /> class.
        /// </summary>
        public GazeDetectionPrediction()
        {
        }
    }
}