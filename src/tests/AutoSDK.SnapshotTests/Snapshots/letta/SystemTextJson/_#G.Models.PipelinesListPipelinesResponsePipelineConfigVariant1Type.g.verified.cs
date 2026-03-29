//HintName: G.Models.PipelinesListPipelinesResponsePipelineConfigVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesListPipelinesResponsePipelineConfigVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        SlackChannelReader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesListPipelinesResponsePipelineConfigVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesListPipelinesResponsePipelineConfigVariant1Type value)
        {
            return value switch
            {
                PipelinesListPipelinesResponsePipelineConfigVariant1Type.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesListPipelinesResponsePipelineConfigVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "slack_channel_reader" => PipelinesListPipelinesResponsePipelineConfigVariant1Type.SlackChannelReader,
                _ => null,
            };
        }
    }
}