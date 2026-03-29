//HintName: G.Models.ApiTasksListFields.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiTasksListFields
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="task_only")]
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