//HintName: G.Models.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GroupUpdateManagerConfigVariant1DiscriminatorManagerType
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
    public static class GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupUpdateManagerConfigVariant1DiscriminatorManagerType value)
        {
            return value switch
            {
                GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Dynamic => "dynamic",
                GroupUpdateManagerConfigVariant1DiscriminatorManagerType.RoundRobin => "round_robin",
                GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Sleeptime => "sleeptime",
                GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Supervisor => "supervisor",
                GroupUpdateManagerConfigVariant1DiscriminatorManagerType.VoiceSleeptime => "voice_sleeptime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupUpdateManagerConfigVariant1DiscriminatorManagerType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Dynamic,
                "round_robin" => GroupUpdateManagerConfigVariant1DiscriminatorManagerType.RoundRobin,
                "sleeptime" => GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Sleeptime,
                "supervisor" => GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Supervisor,
                "voice_sleeptime" => GroupUpdateManagerConfigVariant1DiscriminatorManagerType.VoiceSleeptime,
                _ => null,
            };
        }
    }
}