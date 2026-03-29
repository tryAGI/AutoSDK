//HintName: G.Models.VoicemailConfigAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Action to take on voicemail detection
    /// </summary>
    public enum VoicemailConfigAction
    {
        /// <summary>
        /// 
        /// </summary>
        Hangup,
        /// <summary>
        /// 
        /// </summary>
        Ignore,
        /// <summary>
        /// 
        /// </summary>
        LeaveMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicemailConfigActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicemailConfigAction value)
        {
            return value switch
            {
                VoicemailConfigAction.Hangup => "hangup",
                VoicemailConfigAction.Ignore => "ignore",
                VoicemailConfigAction.LeaveMessage => "leave_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicemailConfigAction? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => VoicemailConfigAction.Hangup,
                "ignore" => VoicemailConfigAction.Ignore,
                "leave_message" => VoicemailConfigAction.LeaveMessage,
                _ => null,
            };
        }
    }
}