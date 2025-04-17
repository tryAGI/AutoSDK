//HintName: G.Models.CompletionJobOutIntegrationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionJobOutIntegrationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Wandb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionJobOutIntegrationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionJobOutIntegrationDiscriminatorType value)
        {
            return value switch
            {
                CompletionJobOutIntegrationDiscriminatorType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionJobOutIntegrationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => CompletionJobOutIntegrationDiscriminatorType.Wandb,
                _ => null,
            };
        }
    }
}