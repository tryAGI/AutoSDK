//HintName: G.Models.ChecksListForSuiteFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: latest
    /// </summary>
    public enum ChecksListForSuiteFilter
    {
        /// <summary>
        /// 
        /// </summary>
        Latest,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksListForSuiteFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksListForSuiteFilter value)
        {
            return value switch
            {
                ChecksListForSuiteFilter.Latest => "latest",
                ChecksListForSuiteFilter.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksListForSuiteFilter? ToEnum(string value)
        {
            return value switch
            {
                "latest" => ChecksListForSuiteFilter.Latest,
                "all" => ChecksListForSuiteFilter.All,
                _ => null,
            };
        }
    }
}