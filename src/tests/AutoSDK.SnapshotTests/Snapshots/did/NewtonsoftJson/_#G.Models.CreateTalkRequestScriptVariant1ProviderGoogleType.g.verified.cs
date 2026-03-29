//HintName: G.Models.CreateTalkRequestScriptVariant1ProviderGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkRequestScriptVariant1ProviderGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTalkRequestScriptVariant1ProviderGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestScriptVariant1ProviderGoogleType value)
        {
            return value switch
            {
                CreateTalkRequestScriptVariant1ProviderGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestScriptVariant1ProviderGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => CreateTalkRequestScriptVariant1ProviderGoogleType.Google,
                _ => null,
            };
        }
    }
}