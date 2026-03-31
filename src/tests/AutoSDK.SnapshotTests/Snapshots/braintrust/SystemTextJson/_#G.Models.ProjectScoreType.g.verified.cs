//HintName: G.Models.ProjectScoreType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the configured score
    /// </summary>
    public enum ProjectScoreType
    {
        /// <summary>
        /// 
        /// </summary>
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        FreeForm,
        /// <summary>
        /// 
        /// </summary>
        Maximum,
        /// <summary>
        /// 
        /// </summary>
        Minimum,
        /// <summary>
        /// 
        /// </summary>
        Online,
        /// <summary>
        /// 
        /// </summary>
        Slider,
        /// <summary>
        /// 
        /// </summary>
        Weighted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectScoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectScoreType value)
        {
            return value switch
            {
                ProjectScoreType.Categorical => "categorical",
                ProjectScoreType.FreeForm => "free-form",
                ProjectScoreType.Maximum => "maximum",
                ProjectScoreType.Minimum => "minimum",
                ProjectScoreType.Online => "online",
                ProjectScoreType.Slider => "slider",
                ProjectScoreType.Weighted => "weighted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectScoreType? ToEnum(string value)
        {
            return value switch
            {
                "categorical" => ProjectScoreType.Categorical,
                "free-form" => ProjectScoreType.FreeForm,
                "maximum" => ProjectScoreType.Maximum,
                "minimum" => ProjectScoreType.Minimum,
                "online" => ProjectScoreType.Online,
                "slider" => ProjectScoreType.Slider,
                "weighted" => ProjectScoreType.Weighted,
                _ => null,
            };
        }
    }
}