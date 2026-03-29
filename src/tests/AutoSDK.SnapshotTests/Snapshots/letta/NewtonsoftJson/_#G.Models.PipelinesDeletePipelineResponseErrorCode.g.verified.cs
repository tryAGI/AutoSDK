//HintName: G.Models.PipelinesDeletePipelineResponseErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinesDeletePipelineResponseErrorCode
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
    public static class PipelinesDeletePipelineResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesDeletePipelineResponseErrorCode value)
        {
            return value switch
            {
                PipelinesDeletePipelineResponseErrorCode.PipelineNotFound => "pipelineNotFound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesDeletePipelineResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "pipelineNotFound" => PipelinesDeletePipelineResponseErrorCode.PipelineNotFound,
                _ => null,
            };
        }
    }
}