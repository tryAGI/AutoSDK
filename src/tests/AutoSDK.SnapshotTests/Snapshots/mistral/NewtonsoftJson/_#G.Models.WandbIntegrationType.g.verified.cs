//HintName: G.Models.WandbIntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: wandb
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WandbIntegrationType
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
    public static class WandbIntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WandbIntegrationType value)
        {
            return value switch
            {
                WandbIntegrationType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WandbIntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => WandbIntegrationType.Wandb,
                _ => null,
            };
        }
    }
}