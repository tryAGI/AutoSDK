//HintName: G.Models.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType value)
        {
            return value switch
            {
                EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType? ToEnum(string value)
        {
            return value switch
            {
                "text" => EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType.Text,
                _ => null,
            };
        }
    }
}