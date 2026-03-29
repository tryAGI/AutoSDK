//HintName: G.Models.TemplatesGetTemplateSnapshotResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesGetTemplateSnapshotResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classic")]
        Classic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cluster")]
        Cluster,
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