//HintName: G.Models.ApiTasksListFields.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiTasksListFields
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        TaskOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiTasksListFieldsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiTasksListFields value)
        {
            return value switch
            {
                ApiTasksListFields.All => "all",
                ApiTasksListFields.TaskOnly => "task_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiTasksListFields? ToEnum(string value)
        {
            return value switch
            {
                "all" => ApiTasksListFields.All,
                "task_only" => ApiTasksListFields.TaskOnly,
                _ => null,
            };
        }
    }
}