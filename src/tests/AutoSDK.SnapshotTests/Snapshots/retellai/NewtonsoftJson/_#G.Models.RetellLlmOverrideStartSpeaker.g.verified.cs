//HintName: G.Models.RetellLlmOverrideStartSpeaker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The speaker who starts the conversation. Required. Must be either 'user' or 'agent'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RetellLlmOverrideStartSpeaker
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent")]
        Agent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetellLlmOverrideStartSpeakerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetellLlmOverrideStartSpeaker value)
        {
            return value switch
            {
                RetellLlmOverrideStartSpeaker.Agent => "agent",
                RetellLlmOverrideStartSpeaker.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetellLlmOverrideStartSpeaker? ToEnum(string value)
        {
            return value switch
            {
                "agent" => RetellLlmOverrideStartSpeaker.Agent,
                "user" => RetellLlmOverrideStartSpeaker.User,
                _ => null,
            };
        }
    }
}