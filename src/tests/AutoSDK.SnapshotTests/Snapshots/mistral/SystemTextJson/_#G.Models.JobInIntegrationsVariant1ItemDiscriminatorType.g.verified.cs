//HintName: G.Models.JobInIntegrationsVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobInIntegrationsVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Wandb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobInIntegrationsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobInIntegrationsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                JobInIntegrationsVariant1ItemDiscriminatorType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobInIntegrationsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => JobInIntegrationsVariant1ItemDiscriminatorType.Wandb,
                _ => null,
            };
        }
    }
}