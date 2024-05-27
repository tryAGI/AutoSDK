//HintName: G.Models.PredictionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The prediction’s status. Valid values are:  
    ///   
    /// * ACTIVE — The Prediction is running and viewers can make predictions.
    /// * CANCELED — The broadcaster canceled the Prediction and refunded the Channel Points to the participants.
    /// * LOCKED — The broadcaster locked the Prediction, which means viewers can no longer make predictions.
    /// * RESOLVED — The winning outcome was determined and the Channel Points were distributed to the viewers who predicted the correct outcome.
    /// </summary>
    public abstract class PredictionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ACTIVE = "ACTIVE";
        /// <summary>
        /// 
        /// </summary>
        public const string CANCELED = "CANCELED";
        /// <summary>
        /// 
        /// </summary>
        public const string LOCKED = "LOCKED";
        /// <summary>
        /// 
        /// </summary>
        public const string RESOLVED = "RESOLVED";
    }
}