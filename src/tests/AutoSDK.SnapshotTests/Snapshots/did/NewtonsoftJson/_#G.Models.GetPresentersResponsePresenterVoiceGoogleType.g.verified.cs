//HintName: G.Models.GetPresentersResponsePresenterVoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPresentersResponsePresenterVoiceGoogleType
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
    public static class GetPresentersResponsePresenterVoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPresentersResponsePresenterVoiceGoogleType value)
        {
            return value switch
            {
                GetPresentersResponsePresenterVoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPresentersResponsePresenterVoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => GetPresentersResponsePresenterVoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}