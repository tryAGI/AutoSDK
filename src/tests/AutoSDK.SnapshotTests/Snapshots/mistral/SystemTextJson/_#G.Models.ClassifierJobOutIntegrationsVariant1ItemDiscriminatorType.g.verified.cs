//HintName: G.Models.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Wandb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierJobOutIntegrationsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType.Wandb,
                _ => null,
            };
        }
    }
}