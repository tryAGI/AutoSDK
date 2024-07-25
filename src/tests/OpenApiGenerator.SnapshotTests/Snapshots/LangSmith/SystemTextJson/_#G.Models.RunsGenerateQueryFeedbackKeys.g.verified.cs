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
        UserScore,
        /// <summary>
        /// 
        /// </summary>
        UserEdited,
        /// <summary>
        /// 
        /// </summary>
        UserRemoved,
        /// <summary>
        /// 
        /// </summary>
        UserOpenedRun,
        /// <summary>
        /// 
        /// </summary>
        UserSelectedRun,
        /// <summary>
        /// 
        /// </summary>
        ResultsSize,
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
                RunsGenerateQueryFeedbackKeys.UserScore => "user_score",
                RunsGenerateQueryFeedbackKeys.UserEdited => "user_edited",
                RunsGenerateQueryFeedbackKeys.UserRemoved => "user_removed",
                RunsGenerateQueryFeedbackKeys.UserOpenedRun => "user_opened_run",
                RunsGenerateQueryFeedbackKeys.UserSelectedRun => "user_selected_run",
                RunsGenerateQueryFeedbackKeys.ResultsSize => "results_size",
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
                "user_score" => RunsGenerateQueryFeedbackKeys.UserScore,
                "user_edited" => RunsGenerateQueryFeedbackKeys.UserEdited,
                "user_removed" => RunsGenerateQueryFeedbackKeys.UserRemoved,
                "user_opened_run" => RunsGenerateQueryFeedbackKeys.UserOpenedRun,
                "user_selected_run" => RunsGenerateQueryFeedbackKeys.UserSelectedRun,
                "results_size" => RunsGenerateQueryFeedbackKeys.ResultsSize,
                "valid_filter" => RunsGenerateQueryFeedbackKeys.ValidFilter,
                _ => null,
            };
        }
    }
}