//HintName: G.Models.ResearchOperationDtoClassVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchOperationDtoClassVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search")]
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchOperationDtoClassVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchOperationDtoClassVariant2Type value)
        {
            return value switch
            {
                ResearchOperationDtoClassVariant2Type.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchOperationDtoClassVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "search" => ResearchOperationDtoClassVariant2Type.Search,
                _ => null,
            };
        }
    }
}