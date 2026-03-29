//HintName: G.Models.EvalRunEndedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the reason for the eval run to end.<br/>
    /// When the eval run is completed normally i.e end of mock conversation, the status is 'mockConversation.done'.<br/>
    /// When the eval fails due to an error like Chat error or incorrect configuration, the status is 'error'.<br/>
    /// When the eval runs for too long, due to model issues or tool call issues, the status is 'timeout'.<br/>
    /// When the eval run is cancelled by the user, the status is 'cancelled'.<br/>
    /// When the eval run is cancelled by Vapi for any reason, the status is 'aborted'.<br/>
    /// Example: mockConversation.done
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalRunEndedReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aborted")]
        Aborted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mockConversation.done")]
        MockConversationDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timeout")]
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalRunEndedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalRunEndedReason value)
        {
            return value switch
            {
                EvalRunEndedReason.Aborted => "aborted",
                EvalRunEndedReason.Cancelled => "cancelled",
                EvalRunEndedReason.Error => "error",
                EvalRunEndedReason.MockConversationDone => "mockConversation.done",
                EvalRunEndedReason.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalRunEndedReason? ToEnum(string value)
        {
            return value switch
            {
                "aborted" => EvalRunEndedReason.Aborted,
                "cancelled" => EvalRunEndedReason.Cancelled,
                "error" => EvalRunEndedReason.Error,
                "mockConversation.done" => EvalRunEndedReason.MockConversationDone,
                "timeout" => EvalRunEndedReason.Timeout,
                _ => null,
            };
        }
    }
}