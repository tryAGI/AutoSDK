//HintName: G.Models.TextAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `text` for text.<br/>
    /// Default Value: text
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextAssetType value)
        {
            return value switch
            {
                TextAssetType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextAssetType? ToEnum(string value)
        {
            return value switch
            {
                "text" => TextAssetType.Text,
                _ => null,
            };
        }
    }
}