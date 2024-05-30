//HintName: G.Models.ListFineTuningJobCheckpointsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFineTuningJobCheckpointsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFineTuningJobCheckpointsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFineTuningJobCheckpointsResponseObject value)
        {
            return value switch
            {
                ListFineTuningJobCheckpointsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFineTuningJobCheckpointsResponseObject ToEnum(string value)
        {
            return value switch
            {
                "list" => ListFineTuningJobCheckpointsResponseObject.List,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}