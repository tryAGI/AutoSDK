//HintName: G.Models.ClipPresenterDtoVoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipPresenterDtoVoiceGoogleType
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
    public static class ClipPresenterDtoVoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipPresenterDtoVoiceGoogleType value)
        {
            return value switch
            {
                ClipPresenterDtoVoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipPresenterDtoVoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => ClipPresenterDtoVoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}