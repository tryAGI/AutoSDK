//HintName: G.Models.FineTuningIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the integration being enabled for the fine-tuning job
    /// </summary>
    public enum FineTuningIntegrationType
    {
        /// <summary>
        /// 
        /// </summary>
        Wandb,
    }

    public static class FineTuningIntegrationTypeExtensions
    {
        public static string ToValueString(this FineTuningIntegrationType value)
        {
            return value switch
            {
                FineTuningIntegrationType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningIntegrationType ToEnum(string value)
        {
            return value switch
            {
                "wandb" => FineTuningIntegrationType.Wandb,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningIntegrationType ToEnum(int value)
        {
            return value switch
            {
                0 => FineTuningIntegrationType.Wandb,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}