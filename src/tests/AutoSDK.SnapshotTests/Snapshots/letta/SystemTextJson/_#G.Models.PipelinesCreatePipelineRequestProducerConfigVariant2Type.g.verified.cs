//HintName: G.Models.PipelinesCreatePipelineRequestProducerConfigVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesCreatePipelineRequestProducerConfigVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        CustomWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesCreatePipelineRequestProducerConfigVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesCreatePipelineRequestProducerConfigVariant2Type value)
        {
            return value switch
            {
                PipelinesCreatePipelineRequestProducerConfigVariant2Type.CustomWebhook => "custom_webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesCreatePipelineRequestProducerConfigVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesCreatePipelineRequestProducerConfigVariant2Type.CustomWebhook,
                _ => null,
            };
        }
    }
}