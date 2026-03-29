//HintName: G.Models.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom_webhook")]
        CustomWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type value)
        {
            return value switch
            {
                PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type.CustomWebhook => "custom_webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type.CustomWebhook,
                _ => null,
            };
        }
    }
}