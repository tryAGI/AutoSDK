//HintName: G.Models.ListPaginatedFineTuningJobsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListPaginatedFineTuningJobsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPaginatedFineTuningJobsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPaginatedFineTuningJobsResponseObject value)
        {
            return value switch
            {
                ListPaginatedFineTuningJobsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPaginatedFineTuningJobsResponseObject ToEnum(string value)
        {
            return value switch
            {
                "list" => ListPaginatedFineTuningJobsResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}