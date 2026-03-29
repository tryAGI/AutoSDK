//HintName: G.Models.ListTestRunsV2ResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTestRunsV2ResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTestRunsV2ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTestRunsV2ResponseStatus value)
        {
            return value switch
            {
                ListTestRunsV2ResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTestRunsV2ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListTestRunsV2ResponseStatus.Error,
                _ => null,
            };
        }
    }
}