//HintName: G.Models.CreateClipRequestScriptVariant1ProviderGoogleType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipRequestScriptVariant1ProviderGoogleType2
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
    public static class CreateClipRequestScriptVariant1ProviderGoogleType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestScriptVariant1ProviderGoogleType2 value)
        {
            return value switch
            {
                CreateClipRequestScriptVariant1ProviderGoogleType2.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestScriptVariant1ProviderGoogleType2? ToEnum(string value)
        {
            return value switch
            {
                "google" => CreateClipRequestScriptVariant1ProviderGoogleType2.Google,
                _ => null,
            };
        }
    }
}