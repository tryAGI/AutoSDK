//HintName: G.Models.JobStatusDiscriminatorJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobStatusDiscriminatorJobType
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
    public static class JobStatusDiscriminatorJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatusDiscriminatorJobType value)
        {
            return value switch
            {
                JobStatusDiscriminatorJobType.Agent => "agent",
                JobStatusDiscriminatorJobType.ImportProjectMedia => "import/project_media",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatusDiscriminatorJobType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => JobStatusDiscriminatorJobType.Agent,
                "import/project_media" => JobStatusDiscriminatorJobType.ImportProjectMedia,
                _ => null,
            };
        }
    }
}