//HintName: G.Models.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType
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
    public static class PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType value)
        {
            return value switch
            {
                PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType.CustomWebhook => "custom_webhook",
                PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType.CustomWebhook,
                "slack_channel_reader" => PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType.SlackChannelReader,
                _ => null,
            };
        }
    }
}