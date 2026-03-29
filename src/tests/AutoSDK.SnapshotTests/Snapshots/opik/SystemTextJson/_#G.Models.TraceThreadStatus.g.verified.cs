//HintName: G.Models.TraceThreadStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceThreadStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceThreadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceThreadStatus value)
        {
            return value switch
            {
                TraceThreadStatus.Active => "active",
                TraceThreadStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceThreadStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => TraceThreadStatus.Active,
                "inactive" => TraceThreadStatus.Inactive,
                _ => null,
            };
        }
    }
}