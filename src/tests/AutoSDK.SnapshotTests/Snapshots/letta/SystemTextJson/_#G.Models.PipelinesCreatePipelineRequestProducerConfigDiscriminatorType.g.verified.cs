//HintName: G.Models.PipelinesCreatePipelineRequestProducerConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesCreatePipelineRequestProducerConfigDiscriminatorType
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
    public static class PipelinesCreatePipelineRequestProducerConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesCreatePipelineRequestProducerConfigDiscriminatorType value)
        {
            return value switch
            {
                PipelinesCreatePipelineRequestProducerConfigDiscriminatorType.CustomWebhook => "custom_webhook",
                PipelinesCreatePipelineRequestProducerConfigDiscriminatorType.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesCreatePipelineRequestProducerConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesCreatePipelineRequestProducerConfigDiscriminatorType.CustomWebhook,
                "slack_channel_reader" => PipelinesCreatePipelineRequestProducerConfigDiscriminatorType.SlackChannelReader,
                _ => null,
            };
        }
    }
}