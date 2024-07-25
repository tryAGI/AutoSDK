//HintName: G.Models.RequestBodyForRunsGenerateQueryFeedbackKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestBodyForRunsGenerateQueryFeedbackKeys
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
    public static class RequestBodyForRunsGenerateQueryFeedbackKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestBodyForRunsGenerateQueryFeedbackKeys value)
        {
            return value switch
            {
                RequestBodyForRunsGenerateQueryFeedbackKeys.UserScore => "user_score",
                RequestBodyForRunsGenerateQueryFeedbackKeys.UserEdited => "user_edited",
                RequestBodyForRunsGenerateQueryFeedbackKeys.UserRemoved => "user_removed",
                RequestBodyForRunsGenerateQueryFeedbackKeys.UserOpenedRun => "user_opened_run",
                RequestBodyForRunsGenerateQueryFeedbackKeys.UserSelectedRun => "user_selected_run",
                RequestBodyForRunsGenerateQueryFeedbackKeys.ResultsSize => "results_size",
                RequestBodyForRunsGenerateQueryFeedbackKeys.ValidFilter => "valid_filter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestBodyForRunsGenerateQueryFeedbackKeys? ToEnum(string value)
        {
            return value switch
            {
                "user_score" => RequestBodyForRunsGenerateQueryFeedbackKeys.UserScore,
                "user_edited" => RequestBodyForRunsGenerateQueryFeedbackKeys.UserEdited,
                "user_removed" => RequestBodyForRunsGenerateQueryFeedbackKeys.UserRemoved,
                "user_opened_run" => RequestBodyForRunsGenerateQueryFeedbackKeys.UserOpenedRun,
                "user_selected_run" => RequestBodyForRunsGenerateQueryFeedbackKeys.UserSelectedRun,
                "results_size" => RequestBodyForRunsGenerateQueryFeedbackKeys.ResultsSize,
                "valid_filter" => RequestBodyForRunsGenerateQueryFeedbackKeys.ValidFilter,
                _ => null,
            };
        }
    }
}