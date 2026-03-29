//HintName: G.Models.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter operator. Possible values:&lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
    /// </summary>
    public enum ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator
    {
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        Contains,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        EndsWith,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        Equal,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        Exists,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        Greater,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        GreaterOrEqual,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        In,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        Less,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        LessOrEqual,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        NotContains,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        NotEqual,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        NotExists,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        NotIn,
        /// <summary>
        /// &lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator value)
        {
            return value switch
            {
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.Contains => "contains",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.EndsWith => "ends_with",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.Equal => "equal",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.Exists => "exists",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.Greater => "greater",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.GreaterOrEqual => "greater_or_equal",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.In => "in",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.Less => "less",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.LessOrEqual => "less_or_equal",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.NotContains => "not_contains",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.NotEqual => "not_equal",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.NotExists => "not_exists",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.NotIn => "not_in",
                ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.Contains,
                "ends_with" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.EndsWith,
                "equal" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.Equal,
                "exists" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.Exists,
                "greater" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.Greater,
                "greater_or_equal" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.GreaterOrEqual,
                "in" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.In,
                "less" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.Less,
                "less_or_equal" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.LessOrEqual,
                "not_contains" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.NotContains,
                "not_equal" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.NotEqual,
                "not_exists" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.NotExists,
                "not_in" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.NotIn,
                "starts_with" => ApiProjectsTasksAssigneesCreateRequestFiltersItemOperator.StartsWith,
                _ => null,
            };
        }
    }
}