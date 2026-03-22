//HintName: G.Models.RunsGenerateQueryFeedbackKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunsGenerateQueryFeedbackKeys
    {
        /// <summary>
        /// 
        /// </summary>
        ResultsSize,
        /// <summary>
        /// 
        /// </summary>
        UserEdited,
        /// <summary>
        /// 
        /// </summary>
        UserOpenedRun,
        /// <summary>
        /// 
        /// </summary>
        UserRemoved,
        /// <summary>
        /// 
        /// </summary>
        UserScore,
        /// <summary>
        /// 
        /// </summary>
        UserSelectedRun,
        /// <summary>
        /// 
        /// </summary>
        ValidFilter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunsGenerateQueryFeedbackKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunsGenerateQueryFeedbackKeys value)
        {
            return value switch
            {
                RunsGenerateQueryFeedbackKeys.ResultsSize => "results_size",
                RunsGenerateQueryFeedbackKeys.UserEdited => "user_edited",
                RunsGenerateQueryFeedbackKeys.UserOpenedRun => "user_opened_run",
                RunsGenerateQueryFeedbackKeys.UserRemoved => "user_removed",
                RunsGenerateQueryFeedbackKeys.UserScore => "user_score",
                RunsGenerateQueryFeedbackKeys.UserSelectedRun => "user_selected_run",
                RunsGenerateQueryFeedbackKeys.ValidFilter => "valid_filter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunsGenerateQueryFeedbackKeys? ToEnum(string value)
        {
            return value switch
            {
                "results_size" => RunsGenerateQueryFeedbackKeys.ResultsSize,
                "user_edited" => RunsGenerateQueryFeedbackKeys.UserEdited,
                "user_opened_run" => RunsGenerateQueryFeedbackKeys.UserOpenedRun,
                "user_removed" => RunsGenerateQueryFeedbackKeys.UserRemoved,
                "user_score" => RunsGenerateQueryFeedbackKeys.UserScore,
                "user_selected_run" => RunsGenerateQueryFeedbackKeys.UserSelectedRun,
                "valid_filter" => RunsGenerateQueryFeedbackKeys.ValidFilter,
                _ => null,
            };
        }
    }
}