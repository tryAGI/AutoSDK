//HintName: G.Models.ProjectSubsetEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `All` - All<br/>
    /// * `HasGT` - HasGT<br/>
    /// * `Sample` - Sample
    /// </summary>
    public enum ProjectSubsetEnum
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        HasGT,
        /// <summary>
        /// 
        /// </summary>
        Sample,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSubsetEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSubsetEnum value)
        {
            return value switch
            {
                ProjectSubsetEnum.All => "All",
                ProjectSubsetEnum.HasGT => "HasGT",
                ProjectSubsetEnum.Sample => "Sample",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSubsetEnum? ToEnum(string value)
        {
            return value switch
            {
                "All" => ProjectSubsetEnum.All,
                "HasGT" => ProjectSubsetEnum.HasGT,
                "Sample" => ProjectSubsetEnum.Sample,
                _ => null,
            };
        }
    }
}