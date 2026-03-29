//HintName: G.Models.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType
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
    public static class InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType value)
        {
            return value switch
            {
                InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.Dynamic => "dynamic",
                InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.RoundRobin => "round_robin",
                InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.Sleeptime => "sleeptime",
                InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.Supervisor => "supervisor",
                InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.VoiceSleeptime => "voice_sleeptime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.Dynamic,
                "round_robin" => InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.RoundRobin,
                "sleeptime" => InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.Sleeptime,
                "supervisor" => InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.Supervisor,
                "voice_sleeptime" => InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType.VoiceSleeptime,
                _ => null,
            };
        }
    }
}