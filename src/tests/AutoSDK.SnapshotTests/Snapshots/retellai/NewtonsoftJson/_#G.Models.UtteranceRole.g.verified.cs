//HintName: G.Models.UtteranceRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Documents whether this utterance is spoken by agent or user.<br/>
    /// Example: agent
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UtteranceRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent")]
        Agent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_target")]
        TransferTarget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UtteranceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UtteranceRole value)
        {
            return value switch
            {
                UtteranceRole.Agent => "agent",
                UtteranceRole.TransferTarget => "transfer_target",
                UtteranceRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UtteranceRole? ToEnum(string value)
        {
            return value switch
            {
                "agent" => UtteranceRole.Agent,
                "transfer_target" => UtteranceRole.TransferTarget,
                "user" => UtteranceRole.User,
                _ => null,
            };
        }
    }
}