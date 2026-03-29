//HintName: G.Models.GroupCreateManagerConfigDiscriminatorManagerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GroupCreateManagerConfigDiscriminatorManagerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dynamic")]
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="round_robin")]
        RoundRobin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sleeptime")]
        Sleeptime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="supervisor")]
        Supervisor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_sleeptime")]
        VoiceSleeptime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupCreateManagerConfigDiscriminatorManagerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupCreateManagerConfigDiscriminatorManagerType value)
        {
            return value switch
            {
                GroupCreateManagerConfigDiscriminatorManagerType.Dynamic => "dynamic",
                GroupCreateManagerConfigDiscriminatorManagerType.RoundRobin => "round_robin",
                GroupCreateManagerConfigDiscriminatorManagerType.Sleeptime => "sleeptime",
                GroupCreateManagerConfigDiscriminatorManagerType.Supervisor => "supervisor",
                GroupCreateManagerConfigDiscriminatorManagerType.VoiceSleeptime => "voice_sleeptime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupCreateManagerConfigDiscriminatorManagerType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => GroupCreateManagerConfigDiscriminatorManagerType.Dynamic,
                "round_robin" => GroupCreateManagerConfigDiscriminatorManagerType.RoundRobin,
                "sleeptime" => GroupCreateManagerConfigDiscriminatorManagerType.Sleeptime,
                "supervisor" => GroupCreateManagerConfigDiscriminatorManagerType.Supervisor,
                "voice_sleeptime" => GroupCreateManagerConfigDiscriminatorManagerType.VoiceSleeptime,
                _ => null,
            };
        }
    }
}