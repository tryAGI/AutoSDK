//HintName: G.Models.GetEvaluationRowsResponseRowItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Evaluation status (only for eval cells)
    /// </summary>
    public enum GetEvaluationRowsResponseRowItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Passed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEvaluationRowsResponseRowItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvaluationRowsResponseRowItemStatus value)
        {
            return value switch
            {
                GetEvaluationRowsResponseRowItemStatus.Failed => "FAILED",
                GetEvaluationRowsResponseRowItemStatus.Passed => "PASSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvaluationRowsResponseRowItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => GetEvaluationRowsResponseRowItemStatus.Failed,
                "PASSED" => GetEvaluationRowsResponseRowItemStatus.Passed,
                _ => null,
            };
        }
    }
}