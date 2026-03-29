//HintName: G.Models.ProjectScoreType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the configured score
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectScoreType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="categorical")]
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="free-form")]
        FreeForm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maximum")]
        Maximum,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimum")]
        Minimum,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="online")]
        Online,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slider")]
        Slider,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="weighted")]
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