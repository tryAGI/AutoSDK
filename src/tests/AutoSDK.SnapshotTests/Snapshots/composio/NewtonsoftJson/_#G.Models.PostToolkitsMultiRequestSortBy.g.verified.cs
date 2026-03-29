//HintName: G.Models.PostToolkitsMultiRequestSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Determines how toolkits should be sorted in the response
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolkitsMultiRequestSortBy
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
    public static class PostToolkitsMultiRequestSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolkitsMultiRequestSortBy value)
        {
            return value switch
            {
                PostToolkitsMultiRequestSortBy.Alphabetically => "alphabetically",
                PostToolkitsMultiRequestSortBy.Usage => "usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolkitsMultiRequestSortBy? ToEnum(string value)
        {
            return value switch
            {
                "alphabetically" => PostToolkitsMultiRequestSortBy.Alphabetically,
                "usage" => PostToolkitsMultiRequestSortBy.Usage,
                _ => null,
            };
        }
    }
}