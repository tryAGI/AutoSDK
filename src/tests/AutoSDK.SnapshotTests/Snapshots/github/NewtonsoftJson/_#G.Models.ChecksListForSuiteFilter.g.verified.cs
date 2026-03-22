//HintName: G.Models.ChecksListForSuiteFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: latest
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChecksListForSuiteFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latest")]
        Latest,
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
                ChecksListForSuiteFilter.All => "all",
                ChecksListForSuiteFilter.Latest => "latest",
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
                "all" => ChecksListForSuiteFilter.All,
                "latest" => ChecksListForSuiteFilter.Latest,
                _ => null,
            };
        }
    }
}