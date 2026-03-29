//HintName: G.Models.SayPhoneNumberHookActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of action - must be "say"
    /// </summary>
    public enum SayPhoneNumberHookActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Say,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SayPhoneNumberHookActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SayPhoneNumberHookActionType value)
        {
            return value switch
            {
                SayPhoneNumberHookActionType.Say => "say",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SayPhoneNumberHookActionType? ToEnum(string value)
        {
            return value switch
            {
                "say" => SayPhoneNumberHookActionType.Say,
                _ => null,
            };
        }
    }
}