//HintName: G.Models.CreateTalkRequestScriptVariant1ProviderMicrosoftType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkRequestScriptVariant1ProviderMicrosoftType2
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
    public static class CreateTalkRequestScriptVariant1ProviderMicrosoftType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestScriptVariant1ProviderMicrosoftType2 value)
        {
            return value switch
            {
                CreateTalkRequestScriptVariant1ProviderMicrosoftType2.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestScriptVariant1ProviderMicrosoftType2? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => CreateTalkRequestScriptVariant1ProviderMicrosoftType2.Microsoft,
                _ => null,
            };
        }
    }
}