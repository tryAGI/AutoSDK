//HintName: G.Models.ExpressiveAgentPresenterVoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveAgentPresenterVoiceMicrosoftType
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
    public static class ExpressiveAgentPresenterVoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAgentPresenterVoiceMicrosoftType value)
        {
            return value switch
            {
                ExpressiveAgentPresenterVoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAgentPresenterVoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => ExpressiveAgentPresenterVoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}