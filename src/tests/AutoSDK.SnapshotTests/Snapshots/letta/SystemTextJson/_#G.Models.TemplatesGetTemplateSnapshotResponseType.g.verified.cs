//HintName: G.Models.TemplatesGetTemplateSnapshotResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesGetTemplateSnapshotResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Classic,
        /// <summary>
        /// 
        /// </summary>
        Cluster,
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
    public static class TemplatesGetTemplateSnapshotResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseType value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseType.Classic => "classic",
                TemplatesGetTemplateSnapshotResponseType.Cluster => "cluster",
                TemplatesGetTemplateSnapshotResponseType.Dynamic => "dynamic",
                TemplatesGetTemplateSnapshotResponseType.RoundRobin => "round_robin",
                TemplatesGetTemplateSnapshotResponseType.Sleeptime => "sleeptime",
                TemplatesGetTemplateSnapshotResponseType.Supervisor => "supervisor",
                TemplatesGetTemplateSnapshotResponseType.VoiceSleeptime => "voice_sleeptime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseType? ToEnum(string value)
        {
            return value switch
            {
                "classic" => TemplatesGetTemplateSnapshotResponseType.Classic,
                "cluster" => TemplatesGetTemplateSnapshotResponseType.Cluster,
                "dynamic" => TemplatesGetTemplateSnapshotResponseType.Dynamic,
                "round_robin" => TemplatesGetTemplateSnapshotResponseType.RoundRobin,
                "sleeptime" => TemplatesGetTemplateSnapshotResponseType.Sleeptime,
                "supervisor" => TemplatesGetTemplateSnapshotResponseType.Supervisor,
                "voice_sleeptime" => TemplatesGetTemplateSnapshotResponseType.VoiceSleeptime,
                _ => null,
            };
        }
    }
}