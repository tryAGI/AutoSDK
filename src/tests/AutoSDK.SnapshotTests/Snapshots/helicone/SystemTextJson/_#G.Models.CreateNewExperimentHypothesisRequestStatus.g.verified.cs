//HintName: G.Models.CreateNewExperimentHypothesisRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateNewExperimentHypothesisRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateNewExperimentHypothesisRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateNewExperimentHypothesisRequestStatus value)
        {
            return value switch
            {
                CreateNewExperimentHypothesisRequestStatus.Completed => "COMPLETED",
                CreateNewExperimentHypothesisRequestStatus.Failed => "FAILED",
                CreateNewExperimentHypothesisRequestStatus.Pending => "PENDING",
                CreateNewExperimentHypothesisRequestStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateNewExperimentHypothesisRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => CreateNewExperimentHypothesisRequestStatus.Completed,
                "FAILED" => CreateNewExperimentHypothesisRequestStatus.Failed,
                "PENDING" => CreateNewExperimentHypothesisRequestStatus.Pending,
                "RUNNING" => CreateNewExperimentHypothesisRequestStatus.Running,
                _ => null,
            };
        }
    }
}