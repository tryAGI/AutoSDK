//HintName: G.Models.GetPresenterByIdResponsePresenterVoiceGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPresenterByIdResponsePresenterVoiceGoogleType
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
    public static class GetPresenterByIdResponsePresenterVoiceGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPresenterByIdResponsePresenterVoiceGoogleType value)
        {
            return value switch
            {
                GetPresenterByIdResponsePresenterVoiceGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPresenterByIdResponsePresenterVoiceGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => GetPresenterByIdResponsePresenterVoiceGoogleType.Google,
                _ => null,
            };
        }
    }
}