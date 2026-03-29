//HintName: G.Models.TitleAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `title` for titles.<br/>
    /// Default Value: title
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TitleAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="title")]
        Title,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TitleAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TitleAssetType value)
        {
            return value switch
            {
                TitleAssetType.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TitleAssetType? ToEnum(string value)
        {
            return value switch
            {
                "title" => TitleAssetType.Title,
                _ => null,
            };
        }
    }
}