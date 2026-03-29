//HintName: G.Models.PipelinesGetPipelineResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesGetPipelineResponseErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipelineNotFound")]
        PipelineNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesGetPipelineResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesGetPipelineResponseErrorCode value)
        {
            return value switch
            {
                PipelinesGetPipelineResponseErrorCode.PipelineNotFound => "pipelineNotFound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesGetPipelineResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "pipelineNotFound" => PipelinesGetPipelineResponseErrorCode.PipelineNotFound,
                _ => null,
            };
        }
    }
}