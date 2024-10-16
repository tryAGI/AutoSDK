//HintName: G.Models.DetailedJobOutRepositorieDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetailedJobOutRepositorieDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetailedJobOutRepositorieDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetailedJobOutRepositorieDiscriminatorType value)
        {
            return value switch
            {
                DetailedJobOutRepositorieDiscriminatorType.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetailedJobOutRepositorieDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "github" => DetailedJobOutRepositorieDiscriminatorType.Github,
                _ => null,
            };
        }
    }
}