//HintName: G.Models.ListJobsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListJobsType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        ImportProjectMedia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListJobsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListJobsType value)
        {
            return value switch
            {
                ListJobsType.Agent => "agent",
                ListJobsType.ImportProjectMedia => "import/project_media",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListJobsType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ListJobsType.Agent,
                "import/project_media" => ListJobsType.ImportProjectMedia,
                _ => null,
            };
        }
    }
}