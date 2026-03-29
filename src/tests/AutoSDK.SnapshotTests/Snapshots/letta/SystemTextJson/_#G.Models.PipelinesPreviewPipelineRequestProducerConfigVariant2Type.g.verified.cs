//HintName: G.Models.PipelinesPreviewPipelineRequestProducerConfigVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesPreviewPipelineRequestProducerConfigVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        CustomWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesPreviewPipelineRequestProducerConfigVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesPreviewPipelineRequestProducerConfigVariant2Type value)
        {
            return value switch
            {
                PipelinesPreviewPipelineRequestProducerConfigVariant2Type.CustomWebhook => "custom_webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesPreviewPipelineRequestProducerConfigVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesPreviewPipelineRequestProducerConfigVariant2Type.CustomWebhook,
                _ => null,
            };
        }
    }
}