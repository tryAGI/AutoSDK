//HintName: G.Models.ManagerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ManagerType
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
        Swarm,
        /// <summary>
        /// 
        /// </summary>
        VoiceSleeptime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagerType value)
        {
            return value switch
            {
                ManagerType.Dynamic => "dynamic",
                ManagerType.RoundRobin => "round_robin",
                ManagerType.Sleeptime => "sleeptime",
                ManagerType.Supervisor => "supervisor",
                ManagerType.Swarm => "swarm",
                ManagerType.VoiceSleeptime => "voice_sleeptime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagerType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => ManagerType.Dynamic,
                "round_robin" => ManagerType.RoundRobin,
                "sleeptime" => ManagerType.Sleeptime,
                "supervisor" => ManagerType.Supervisor,
                "swarm" => ManagerType.Swarm,
                "voice_sleeptime" => ManagerType.VoiceSleeptime,
                _ => null,
            };
        }
    }
}