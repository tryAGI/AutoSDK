//HintName: G.Models.JobInRepositoriesVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobInRepositoriesVariant1ItemDiscriminatorType
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
    public static class JobInRepositoriesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobInRepositoriesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                JobInRepositoriesVariant1ItemDiscriminatorType.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobInRepositoriesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "github" => JobInRepositoriesVariant1ItemDiscriminatorType.Github,
                _ => null,
            };
        }
    }
}