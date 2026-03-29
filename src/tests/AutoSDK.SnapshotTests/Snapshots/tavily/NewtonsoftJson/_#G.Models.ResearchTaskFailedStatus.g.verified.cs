//HintName: G.Models.ResearchTaskFailedStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the research task.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchTaskFailedStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchTaskFailedStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchTaskFailedStatus value)
        {
            return value switch
            {
                ResearchTaskFailedStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchTaskFailedStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ResearchTaskFailedStatus.Failed,
                _ => null,
            };
        }
    }
}