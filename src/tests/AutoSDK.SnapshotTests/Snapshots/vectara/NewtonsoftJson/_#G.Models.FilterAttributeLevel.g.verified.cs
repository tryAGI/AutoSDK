//HintName: G.Models.FilterAttributeLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates whether this a document or document part metadata filter.<br/>
    /// Example: document
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterAttributeLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document")]
        Document,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="part")]
        Part,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterAttributeLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterAttributeLevel value)
        {
            return value switch
            {
                FilterAttributeLevel.Document => "document",
                FilterAttributeLevel.Part => "part",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterAttributeLevel? ToEnum(string value)
        {
            return value switch
            {
                "document" => FilterAttributeLevel.Document,
                "part" => FilterAttributeLevel.Part,
                _ => null,
            };
        }
    }
}