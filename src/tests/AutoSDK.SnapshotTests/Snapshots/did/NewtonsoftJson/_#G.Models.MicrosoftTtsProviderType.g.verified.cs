//HintName: G.Models.MicrosoftTtsProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MicrosoftTtsProviderType
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
    public static class MicrosoftTtsProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MicrosoftTtsProviderType value)
        {
            return value switch
            {
                MicrosoftTtsProviderType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MicrosoftTtsProviderType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => MicrosoftTtsProviderType.Microsoft,
                _ => null,
            };
        }
    }
}