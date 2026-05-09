//HintName: G.Models.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType
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
    public static class PipelinesCreatePipelineResponsePipelineConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType value)
        {
            return value switch
            {
                PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType.CustomWebhook => "custom_webhook",
                PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType.CustomWebhook,
                "slack_channel_reader" => PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType.SlackChannelReader,
                _ => null,
            };
        }
    }
}