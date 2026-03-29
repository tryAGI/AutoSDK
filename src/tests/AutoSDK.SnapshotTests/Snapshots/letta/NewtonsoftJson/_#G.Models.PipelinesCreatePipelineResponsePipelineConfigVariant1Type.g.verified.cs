//HintName: G.Models.PipelinesCreatePipelineResponsePipelineConfigVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesCreatePipelineResponsePipelineConfigVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack_channel_reader")]
        SlackChannelReader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesCreatePipelineResponsePipelineConfigVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesCreatePipelineResponsePipelineConfigVariant1Type value)
        {
            return value switch
            {
                PipelinesCreatePipelineResponsePipelineConfigVariant1Type.SlackChannelReader => "slack_channel_reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesCreatePipelineResponsePipelineConfigVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "slack_channel_reader" => PipelinesCreatePipelineResponsePipelineConfigVariant1Type.SlackChannelReader,
                _ => null,
            };
        }
    }
}