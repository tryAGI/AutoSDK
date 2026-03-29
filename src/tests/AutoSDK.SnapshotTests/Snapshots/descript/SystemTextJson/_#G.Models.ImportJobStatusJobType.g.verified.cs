//HintName: G.Models.ImportJobStatusJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of job
    /// </summary>
    public enum ImportJobStatusJobType
    {
        /// <summary>
        /// 
        /// </summary>
        ImportProjectMedia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportJobStatusJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportJobStatusJobType value)
        {
            return value switch
            {
                ImportJobStatusJobType.ImportProjectMedia => "import/project_media",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportJobStatusJobType? ToEnum(string value)
        {
            return value switch
            {
                "import/project_media" => ImportJobStatusJobType.ImportProjectMedia,
                _ => null,
            };
        }
    }
}