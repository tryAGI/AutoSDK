//HintName: G.Models.PipelinesGetPipelineResponsePipelineConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesGetPipelineResponsePipelineConfigDiscriminatorType
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
    public static class PipelinesGetPipelineResponsePipelineConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesGetPipelineResponsePipelineConfigDiscriminatorType value)
        {
            return value switch
            {
                PipelinesGetPipelineResponsePipelineConfigDiscriminatorType.CustomWebhook => "custom_webhook",
                PipelinesGetPipelineResponsePipelineConfigDiscriminatorType.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesGetPipelineResponsePipelineConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesGetPipelineResponsePipelineConfigDiscriminatorType.CustomWebhook,
                "slack_channel_reader" => PipelinesGetPipelineResponsePipelineConfigDiscriminatorType.SlackChannelReader,
                _ => null,
            };
        }
    }
}