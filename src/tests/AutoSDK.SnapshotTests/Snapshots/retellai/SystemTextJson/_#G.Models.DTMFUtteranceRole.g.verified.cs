//HintName: G.Models.DTMFUtteranceRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Digit pressed by the user from their phone keypad.
    /// </summary>
    public enum DTMFUtteranceRole
    {
        /// <summary>
        /// 
        /// </summary>
        Dtmf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DTMFUtteranceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DTMFUtteranceRole value)
        {
            return value switch
            {
                DTMFUtteranceRole.Dtmf => "dtmf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DTMFUtteranceRole? ToEnum(string value)
        {
            return value switch
            {
                "dtmf" => DTMFUtteranceRole.Dtmf,
                _ => null,
            };
        }
    }
}