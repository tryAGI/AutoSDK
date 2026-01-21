//HintName: G.Models.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wandb")]
        Wandb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType.Wandb,
                _ => null,
            };
        }
    }
}