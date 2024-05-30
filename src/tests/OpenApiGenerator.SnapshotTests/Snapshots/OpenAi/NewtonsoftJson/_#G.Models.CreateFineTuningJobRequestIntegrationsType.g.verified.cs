//HintName: G.Models.CreateFineTuningJobRequestIntegrationsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateFineTuningJobRequestIntegrationsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wandb")]
        Wandb,
    }

    public static class CreateFineTuningJobRequestIntegrationsTypeExtensions
    {
        public static string ToValueString(this CreateFineTuningJobRequestIntegrationsType value)
        {
            return value switch
            {
                CreateFineTuningJobRequestIntegrationsType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFineTuningJobRequestIntegrationsType ToEnum(string value)
        {
            return value switch
            {
                "wandb" => CreateFineTuningJobRequestIntegrationsType.Wandb,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFineTuningJobRequestIntegrationsType ToEnum(int value)
        {
            return value switch
            {
                0 => CreateFineTuningJobRequestIntegrationsType.Wandb,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}