//HintName: G.Models.ResearchTaskCompletedStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the research task.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchTaskCompletedStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchTaskCompletedStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchTaskCompletedStatus value)
        {
            return value switch
            {
                ResearchTaskCompletedStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchTaskCompletedStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResearchTaskCompletedStatus.Completed,
                _ => null,
            };
        }
    }
}