//HintName: G.Models.ScriptVariant1ProviderMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScriptVariant1ProviderMicrosoftType
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
    public static class ScriptVariant1ProviderMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScriptVariant1ProviderMicrosoftType value)
        {
            return value switch
            {
                ScriptVariant1ProviderMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScriptVariant1ProviderMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => ScriptVariant1ProviderMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}