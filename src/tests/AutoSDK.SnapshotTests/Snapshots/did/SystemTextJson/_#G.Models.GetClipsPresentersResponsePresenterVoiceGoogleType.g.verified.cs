//HintName: G.Models.GetClipsPresentersResponsePresenterVoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetClipsPresentersResponsePresenterVoiceGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetClipsPresentersResponsePresenterVoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipsPresentersResponsePresenterVoiceGoogleType value)
        {
            return value switch
            {
                GetClipsPresentersResponsePresenterVoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipsPresentersResponsePresenterVoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => GetClipsPresentersResponsePresenterVoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}