//HintName: G.Models.SearchRequestVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of search to perform.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchRequestVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="images")]
        Images,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maps")]
        Maps,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="news")]
        News,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patents")]
        Patents,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="places")]
        Places,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scholar")]
        Scholar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search")]
        Search,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shopping")]
        Shopping,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="videos")]
        Videos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestVariant2Type value)
        {
            return value switch
            {
                SearchRequestVariant2Type.Images => "images",
                SearchRequestVariant2Type.Maps => "maps",
                SearchRequestVariant2Type.News => "news",
                SearchRequestVariant2Type.Patents => "patents",
                SearchRequestVariant2Type.Places => "places",
                SearchRequestVariant2Type.Scholar => "scholar",
                SearchRequestVariant2Type.Search => "search",
                SearchRequestVariant2Type.Shopping => "shopping",
                SearchRequestVariant2Type.Videos => "videos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "images" => SearchRequestVariant2Type.Images,
                "maps" => SearchRequestVariant2Type.Maps,
                "news" => SearchRequestVariant2Type.News,
                "patents" => SearchRequestVariant2Type.Patents,
                "places" => SearchRequestVariant2Type.Places,
                "scholar" => SearchRequestVariant2Type.Scholar,
                "search" => SearchRequestVariant2Type.Search,
                "shopping" => SearchRequestVariant2Type.Shopping,
                "videos" => SearchRequestVariant2Type.Videos,
                _ => null,
            };
        }
    }
}