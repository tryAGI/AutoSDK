//HintName: G.Models.RequestBodyForRunsGenerateQueryFeedbackKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestBodyForRunsGenerateQueryFeedbackKeys
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_score")]
        UserScore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_edited")]
        UserEdited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_removed")]
        UserRemoved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_opened_run")]
        UserOpenedRun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_selected_run")]
        UserSelectedRun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="results_size")]
        ResultsSize,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="valid_filter")]
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