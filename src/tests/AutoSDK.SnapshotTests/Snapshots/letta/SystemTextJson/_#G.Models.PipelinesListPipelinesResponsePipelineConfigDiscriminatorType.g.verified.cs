//HintName: G.Models.PipelinesListPipelinesResponsePipelineConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesListPipelinesResponsePipelineConfigDiscriminatorType
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
    public static class PipelinesListPipelinesResponsePipelineConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesListPipelinesResponsePipelineConfigDiscriminatorType value)
        {
            return value switch
            {
                PipelinesListPipelinesResponsePipelineConfigDiscriminatorType.CustomWebhook => "custom_webhook",
                PipelinesListPipelinesResponsePipelineConfigDiscriminatorType.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesListPipelinesResponsePipelineConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesListPipelinesResponsePipelineConfigDiscriminatorType.CustomWebhook,
                "slack_channel_reader" => PipelinesListPipelinesResponsePipelineConfigDiscriminatorType.SlackChannelReader,
                _ => null,
            };
        }
    }
}