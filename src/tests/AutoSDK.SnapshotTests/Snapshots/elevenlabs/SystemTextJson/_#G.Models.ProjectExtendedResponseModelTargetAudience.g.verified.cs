//HintName: G.Models.ProjectExtendedResponseModelTargetAudience.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectExtendedResponseModelTargetAudience
    {
        /// <summary>
        /// 
        /// </summary>
        Adult,
        /// <summary>
        /// 
        /// </summary>
        AllAges,
        /// <summary>
        /// 
        /// </summary>
        Children,
        /// <summary>
        /// 
        /// </summary>
        YoungAdult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExtendedResponseModelTargetAudienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelTargetAudience value)
        {
            return value switch
            {
                ProjectExtendedResponseModelTargetAudience.Adult => "adult",
                ProjectExtendedResponseModelTargetAudience.AllAges => "all ages",
                ProjectExtendedResponseModelTargetAudience.Children => "children",
                ProjectExtendedResponseModelTargetAudience.YoungAdult => "young adult",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelTargetAudience? ToEnum(string value)
        {
            return value switch
            {
                "adult" => ProjectExtendedResponseModelTargetAudience.Adult,
                "all ages" => ProjectExtendedResponseModelTargetAudience.AllAges,
                "children" => ProjectExtendedResponseModelTargetAudience.Children,
                "young adult" => ProjectExtendedResponseModelTargetAudience.YoungAdult,
                _ => null,
            };
        }
    }
}