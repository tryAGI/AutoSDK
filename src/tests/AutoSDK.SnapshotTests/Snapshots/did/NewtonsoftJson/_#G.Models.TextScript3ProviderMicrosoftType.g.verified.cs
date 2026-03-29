//HintName: G.Models.TextScript3ProviderMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextScript3ProviderMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="microsoft")]
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextScript3ProviderMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScript3ProviderMicrosoftType value)
        {
            return value switch
            {
                TextScript3ProviderMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScript3ProviderMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => TextScript3ProviderMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}