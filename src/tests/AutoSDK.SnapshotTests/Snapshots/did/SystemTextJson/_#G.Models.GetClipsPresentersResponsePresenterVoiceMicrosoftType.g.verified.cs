//HintName: G.Models.GetClipsPresentersResponsePresenterVoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetClipsPresentersResponsePresenterVoiceMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetClipsPresentersResponsePresenterVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetClipsPresentersResponsePresenterVoiceMicrosoftType value)
        {
            return value switch
            {
                GetClipsPresentersResponsePresenterVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetClipsPresentersResponsePresenterVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => GetClipsPresentersResponsePresenterVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}