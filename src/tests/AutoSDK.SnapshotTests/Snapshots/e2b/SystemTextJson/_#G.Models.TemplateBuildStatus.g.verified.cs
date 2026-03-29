//HintName: G.Models.TemplateBuildStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the template build
    /// </summary>
    public enum TemplateBuildStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Building,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateBuildStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateBuildStatus value)
        {
            return value switch
            {
                TemplateBuildStatus.Building => "building",
                TemplateBuildStatus.Error => "error",
                TemplateBuildStatus.Ready => "ready",
                TemplateBuildStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateBuildStatus? ToEnum(string value)
        {
            return value switch
            {
                "building" => TemplateBuildStatus.Building,
                "error" => TemplateBuildStatus.Error,
                "ready" => TemplateBuildStatus.Ready,
                "waiting" => TemplateBuildStatus.Waiting,
                _ => null,
            };
        }
    }
}