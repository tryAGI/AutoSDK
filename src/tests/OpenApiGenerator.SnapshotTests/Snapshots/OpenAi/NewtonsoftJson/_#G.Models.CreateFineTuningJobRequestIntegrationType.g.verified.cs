//HintName: G.Models.CreateFineTuningJobRequestIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateFineTuningJobRequestIntegrationType
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
    public static class CreateFineTuningJobRequestIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFineTuningJobRequestIntegrationType value)
        {
            return value switch
            {
                CreateFineTuningJobRequestIntegrationType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFineTuningJobRequestIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => CreateFineTuningJobRequestIntegrationType.Wandb,
                _ => null,
            };
        }
    }
}