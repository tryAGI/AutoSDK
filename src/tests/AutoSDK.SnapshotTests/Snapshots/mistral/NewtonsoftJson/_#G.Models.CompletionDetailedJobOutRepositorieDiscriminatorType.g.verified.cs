//HintName: G.Models.CompletionDetailedJobOutRepositorieDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompletionDetailedJobOutRepositorieDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="github")]
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionDetailedJobOutRepositorieDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionDetailedJobOutRepositorieDiscriminatorType value)
        {
            return value switch
            {
                CompletionDetailedJobOutRepositorieDiscriminatorType.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionDetailedJobOutRepositorieDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "github" => CompletionDetailedJobOutRepositorieDiscriminatorType.Github,
                _ => null,
            };
        }
    }
}