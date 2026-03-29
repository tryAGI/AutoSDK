//HintName: G.Models.GroupSchemaManagerConfigDiscriminatorManagerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GroupSchemaManagerConfigDiscriminatorManagerType
    {
        /// <summary>
        /// 
        /// </summary>
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        RoundRobin,
        /// <summary>
        /// 
        /// </summary>
        Sleeptime,
        /// <summary>
        /// 
        /// </summary>
        Supervisor,
        /// <summary>
        /// 
        /// </summary>
        VoiceSleeptime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupSchemaManagerConfigDiscriminatorManagerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupSchemaManagerConfigDiscriminatorManagerType value)
        {
            return value switch
            {
                GroupSchemaManagerConfigDiscriminatorManagerType.Dynamic => "dynamic",
                GroupSchemaManagerConfigDiscriminatorManagerType.RoundRobin => "round_robin",
                GroupSchemaManagerConfigDiscriminatorManagerType.Sleeptime => "sleeptime",
                GroupSchemaManagerConfigDiscriminatorManagerType.Supervisor => "supervisor",
                GroupSchemaManagerConfigDiscriminatorManagerType.VoiceSleeptime => "voice_sleeptime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupSchemaManagerConfigDiscriminatorManagerType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => GroupSchemaManagerConfigDiscriminatorManagerType.Dynamic,
                "round_robin" => GroupSchemaManagerConfigDiscriminatorManagerType.RoundRobin,
                "sleeptime" => GroupSchemaManagerConfigDiscriminatorManagerType.Sleeptime,
                "supervisor" => GroupSchemaManagerConfigDiscriminatorManagerType.Supervisor,
                "voice_sleeptime" => GroupSchemaManagerConfigDiscriminatorManagerType.VoiceSleeptime,
                _ => null,
            };
        }
    }
}