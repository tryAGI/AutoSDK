//HintName: G.Models.WandbIntegrationOutType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: wandb
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WandbIntegrationOutType
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
    public static class WandbIntegrationOutTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WandbIntegrationOutType value)
        {
            return value switch
            {
                WandbIntegrationOutType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WandbIntegrationOutType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => WandbIntegrationOutType.Wandb,
                _ => null,
            };
        }
    }
}