//HintName: G.Models.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom_webhook")]
        CustomWebhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack_channel_reader")]
        SlackChannelReader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType value)
        {
            return value switch
            {
                PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType.CustomWebhook => "custom_webhook",
                PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType.CustomWebhook,
                "slack_channel_reader" => PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType.SlackChannelReader,
                _ => null,
            };
        }
    }
}