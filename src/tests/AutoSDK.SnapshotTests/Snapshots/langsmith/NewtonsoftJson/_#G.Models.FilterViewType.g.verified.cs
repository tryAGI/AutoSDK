//HintName: G.Models.FilterViewType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterViewType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="runs")]
        Runs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="threads")]
        Threads,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterViewType value)
        {
            return value switch
            {
                FilterViewType.Runs => "runs",
                FilterViewType.Threads => "threads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterViewType? ToEnum(string value)
        {
            return value switch
            {
                "runs" => FilterViewType.Runs,
                "threads" => FilterViewType.Threads,
                _ => null,
            };
        }
    }
}