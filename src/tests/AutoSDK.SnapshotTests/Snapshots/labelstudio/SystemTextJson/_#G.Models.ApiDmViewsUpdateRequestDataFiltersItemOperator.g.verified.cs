//HintName: G.Models.ApiDmViewsUpdateRequestDataFiltersItemOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter operator. Possible values:&lt;li&gt;`contains` Contains&lt;/li&gt;&lt;li&gt;`ends_with` Ends with&lt;/li&gt;&lt;li&gt;`equal` Equal to&lt;/li&gt;&lt;li&gt;`exists` Exists&lt;/li&gt;&lt;li&gt;`greater` Greater than&lt;/li&gt;&lt;li&gt;`greater_or_equal` Greater than or equal to&lt;/li&gt;&lt;li&gt;`in` Is between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`less` Less than&lt;/li&gt;&lt;li&gt;`less_or_equal` Less than or equal to&lt;/li&gt;&lt;li&gt;`not_contains` Does not contain&lt;/li&gt;&lt;li&gt;`not_equal` Not equal to&lt;/li&gt;&lt;li&gt;`not_exists` Does not exist&lt;/li&gt;&lt;li&gt;`not_in` Is not between min and max values, so the filter `value` should be e.g. `{"min": 1, "max": 7}`&lt;/li&gt;&lt;li&gt;`starts_with` Starts with&lt;/li&gt;
    /// </summary>
    public enum ApiDmViewsUpdateRequestDataFiltersItemOperator
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
    public static class ApiDmViewsUpdateRequestDataFiltersItemOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiDmViewsUpdateRequestDataFiltersItemOperator value)
        {
            return value switch
            {
                ApiDmViewsUpdateRequestDataFiltersItemOperator.Contains => "contains",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.EndsWith => "ends_with",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.Equal => "equal",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.Exists => "exists",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.Greater => "greater",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.GreaterOrEqual => "greater_or_equal",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.In => "in",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.Less => "less",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.LessOrEqual => "less_or_equal",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.NotContains => "not_contains",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.NotEqual => "not_equal",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.NotExists => "not_exists",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.NotIn => "not_in",
                ApiDmViewsUpdateRequestDataFiltersItemOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiDmViewsUpdateRequestDataFiltersItemOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => ApiDmViewsUpdateRequestDataFiltersItemOperator.Contains,
                "ends_with" => ApiDmViewsUpdateRequestDataFiltersItemOperator.EndsWith,
                "equal" => ApiDmViewsUpdateRequestDataFiltersItemOperator.Equal,
                "exists" => ApiDmViewsUpdateRequestDataFiltersItemOperator.Exists,
                "greater" => ApiDmViewsUpdateRequestDataFiltersItemOperator.Greater,
                "greater_or_equal" => ApiDmViewsUpdateRequestDataFiltersItemOperator.GreaterOrEqual,
                "in" => ApiDmViewsUpdateRequestDataFiltersItemOperator.In,
                "less" => ApiDmViewsUpdateRequestDataFiltersItemOperator.Less,
                "less_or_equal" => ApiDmViewsUpdateRequestDataFiltersItemOperator.LessOrEqual,
                "not_contains" => ApiDmViewsUpdateRequestDataFiltersItemOperator.NotContains,
                "not_equal" => ApiDmViewsUpdateRequestDataFiltersItemOperator.NotEqual,
                "not_exists" => ApiDmViewsUpdateRequestDataFiltersItemOperator.NotExists,
                "not_in" => ApiDmViewsUpdateRequestDataFiltersItemOperator.NotIn,
                "starts_with" => ApiDmViewsUpdateRequestDataFiltersItemOperator.StartsWith,
                _ => null,
            };
        }
    }
}