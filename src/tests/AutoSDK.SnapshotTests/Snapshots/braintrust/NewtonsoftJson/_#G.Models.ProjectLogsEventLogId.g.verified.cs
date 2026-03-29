//HintName: G.Models.ProjectLogsEventLogId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A literal 'g' which identifies the log as a project log
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectLogsEventLogId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="g")]
        G,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectLogsEventLogIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectLogsEventLogId value)
        {
            return value switch
            {
                ProjectLogsEventLogId.G => "g",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectLogsEventLogId? ToEnum(string value)
        {
            return value switch
            {
                "g" => ProjectLogsEventLogId.G,
                _ => null,
            };
        }
    }
}