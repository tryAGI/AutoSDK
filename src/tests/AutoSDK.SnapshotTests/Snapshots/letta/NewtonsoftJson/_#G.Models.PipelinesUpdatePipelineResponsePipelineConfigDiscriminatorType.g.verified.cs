//HintName: G.Models.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType
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
    public static class PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType value)
        {
            return value switch
            {
                PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType.CustomWebhook => "custom_webhook",
                PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType.CustomWebhook,
                "slack_channel_reader" => PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType.SlackChannelReader,
                _ => null,
            };
        }
    }
}