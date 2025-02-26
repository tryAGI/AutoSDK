//HintName: G.Models.CitationsDeltaCitationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CitationsDeltaCitationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="char_location")]
        CharLocation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_location")]
        ContentBlockLocation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page_location")]
        PageLocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationsDeltaCitationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationsDeltaCitationDiscriminatorType value)
        {
            return value switch
            {
                CitationsDeltaCitationDiscriminatorType.CharLocation => "char_location",
                CitationsDeltaCitationDiscriminatorType.ContentBlockLocation => "content_block_location",
                CitationsDeltaCitationDiscriminatorType.PageLocation => "page_location",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationsDeltaCitationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "char_location" => CitationsDeltaCitationDiscriminatorType.CharLocation,
                "content_block_location" => CitationsDeltaCitationDiscriminatorType.ContentBlockLocation,
                "page_location" => CitationsDeltaCitationDiscriminatorType.PageLocation,
                _ => null,
            };
        }
    }
}