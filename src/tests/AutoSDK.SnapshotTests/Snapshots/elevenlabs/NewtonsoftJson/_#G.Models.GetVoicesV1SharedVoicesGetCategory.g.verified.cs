//HintName: G.Models.GetVoicesV1SharedVoicesGetCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice category used for filtering<br/>
    /// Example: professional
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetVoicesV1SharedVoicesGetCategory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="professional")]
        Professional,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="famous")]
        Famous,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high_quality")]
        HighQuality,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVoicesV1SharedVoicesGetCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVoicesV1SharedVoicesGetCategory value)
        {
            return value switch
            {
                GetVoicesV1SharedVoicesGetCategory.Professional => "professional",
                GetVoicesV1SharedVoicesGetCategory.Famous => "famous",
                GetVoicesV1SharedVoicesGetCategory.HighQuality => "high_quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVoicesV1SharedVoicesGetCategory? ToEnum(string value)
        {
            return value switch
            {
                "professional" => GetVoicesV1SharedVoicesGetCategory.Professional,
                "famous" => GetVoicesV1SharedVoicesGetCategory.Famous,
                "high_quality" => GetVoicesV1SharedVoicesGetCategory.HighQuality,
                _ => null,
            };
        }
    }
}