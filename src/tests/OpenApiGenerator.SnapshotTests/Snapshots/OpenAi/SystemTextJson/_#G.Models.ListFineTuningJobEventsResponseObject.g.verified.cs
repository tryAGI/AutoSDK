//HintName: G.Models.ListFineTuningJobEventsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFineTuningJobEventsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    public static class ListFineTuningJobEventsResponseObjectExtensions
    {
        public static string ToValueString(this ListFineTuningJobEventsResponseObject value)
        {
            return value switch
            {
                ListFineTuningJobEventsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListFineTuningJobEventsResponseObject ToEnum(string value)
        {
            return value switch
            {
                "list" => ListFineTuningJobEventsResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListFineTuningJobEventsResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => ListFineTuningJobEventsResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}