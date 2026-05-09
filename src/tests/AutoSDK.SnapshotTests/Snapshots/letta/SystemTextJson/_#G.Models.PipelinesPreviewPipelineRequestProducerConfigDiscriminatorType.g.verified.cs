//HintName: G.Models.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomWebhook,
        /// <summary>
        /// 
        /// </summary>
        SlackChannelReader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesPreviewPipelineRequestProducerConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType value)
        {
            return value switch
            {
                PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType.CustomWebhook => "custom_webhook",
                PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType.CustomWebhook,
                "slack_channel_reader" => PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType.SlackChannelReader,
                _ => null,
            };
        }
    }
}