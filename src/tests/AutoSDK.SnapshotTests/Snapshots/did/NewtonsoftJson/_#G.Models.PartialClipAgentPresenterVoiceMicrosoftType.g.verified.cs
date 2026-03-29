//HintName: G.Models.PartialClipAgentPresenterVoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialClipAgentPresenterVoiceMicrosoftType
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
    public static class PartialClipAgentPresenterVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialClipAgentPresenterVoiceMicrosoftType value)
        {
            return value switch
            {
                PartialClipAgentPresenterVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialClipAgentPresenterVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => PartialClipAgentPresenterVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}