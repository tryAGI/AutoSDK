//HintName: G.Models.ProjectExtendedResponseModelAspectRatio2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectExtendedResponseModelAspectRatio2
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
        /// <summary>
        /// 
        /// </summary>
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExtendedResponseModelAspectRatio2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelAspectRatio2 value)
        {
            return value switch
            {
                ProjectExtendedResponseModelAspectRatio2.x16_9 => "16:9",
                ProjectExtendedResponseModelAspectRatio2.x9_16 => "9:16",
                ProjectExtendedResponseModelAspectRatio2.x4_5 => "4:5",
                ProjectExtendedResponseModelAspectRatio2.x1_1 => "1:1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelAspectRatio2? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ProjectExtendedResponseModelAspectRatio2.x16_9,
                "9:16" => ProjectExtendedResponseModelAspectRatio2.x9_16,
                "4:5" => ProjectExtendedResponseModelAspectRatio2.x4_5,
                "1:1" => ProjectExtendedResponseModelAspectRatio2.x1_1,
                _ => null,
            };
        }
    }
}