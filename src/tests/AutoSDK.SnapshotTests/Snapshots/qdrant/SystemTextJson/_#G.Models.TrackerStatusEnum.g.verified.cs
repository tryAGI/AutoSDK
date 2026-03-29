//HintName: G.Models.TrackerStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrackerStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Optimizing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackerStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackerStatusEnum value)
        {
            return value switch
            {
                TrackerStatusEnum.Done => "done",
                TrackerStatusEnum.Optimizing => "optimizing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackerStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "done" => TrackerStatusEnum.Done,
                "optimizing" => TrackerStatusEnum.Optimizing,
                _ => null,
            };
        }
    }
}