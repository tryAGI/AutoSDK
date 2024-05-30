//HintName: G.Models.FineTuningIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the integration being enabled for the fine-tuning job
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuningIntegrationType
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
    public static class FineTuningIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningIntegrationType value)
        {
            return value switch
            {
                FineTuningIntegrationType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningIntegrationType ToEnum(string value)
        {
            return value switch
            {
                "wandb" => FineTuningIntegrationType.Wandb,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}