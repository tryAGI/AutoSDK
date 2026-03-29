//HintName: G.Models.GetToolkitsSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Determines how toolkits should be sorted in the response
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetToolkitsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alphabetically")]
        Alphabetically,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="usage")]
        Usage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolkitsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolkitsSortBy value)
        {
            return value switch
            {
                GetToolkitsSortBy.Alphabetically => "alphabetically",
                GetToolkitsSortBy.Usage => "usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolkitsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "alphabetically" => GetToolkitsSortBy.Alphabetically,
                "usage" => GetToolkitsSortBy.Usage,
                _ => null,
            };
        }
    }
}