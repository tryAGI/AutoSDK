//HintName: G.Models.ChecksListForRefFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: latest
    /// </summary>
    public enum ChecksListForRefFilter
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksListForRefFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksListForRefFilter value)
        {
            return value switch
            {
                ChecksListForRefFilter.All => "all",
                ChecksListForRefFilter.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksListForRefFilter? ToEnum(string value)
        {
            return value switch
            {
                "all" => ChecksListForRefFilter.All,
                "latest" => ChecksListForRefFilter.Latest,
                _ => null,
            };
        }
    }
}