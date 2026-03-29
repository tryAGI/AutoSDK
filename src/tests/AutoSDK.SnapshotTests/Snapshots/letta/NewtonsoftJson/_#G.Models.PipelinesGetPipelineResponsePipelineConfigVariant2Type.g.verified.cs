//HintName: G.Models.PipelinesGetPipelineResponsePipelineConfigVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesGetPipelineResponsePipelineConfigVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom_webhook")]
        CustomWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesGetPipelineResponsePipelineConfigVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesGetPipelineResponsePipelineConfigVariant2Type value)
        {
            return value switch
            {
                PipelinesGetPipelineResponsePipelineConfigVariant2Type.CustomWebhook => "custom_webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesGetPipelineResponsePipelineConfigVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom_webhook" => PipelinesGetPipelineResponsePipelineConfigVariant2Type.CustomWebhook,
                _ => null,
            };
        }
    }
}