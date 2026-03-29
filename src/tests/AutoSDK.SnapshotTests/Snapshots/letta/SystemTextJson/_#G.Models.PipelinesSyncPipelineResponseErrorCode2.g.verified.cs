//HintName: G.Models.PipelinesSyncPipelineResponseErrorCode2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinesSyncPipelineResponseErrorCode2
    {
        /// <summary>
        /// 
        /// </summary>
        PipelineNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinesSyncPipelineResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinesSyncPipelineResponseErrorCode2 value)
        {
            return value switch
            {
                PipelinesSyncPipelineResponseErrorCode2.PipelineNotFound => "pipelineNotFound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinesSyncPipelineResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "pipelineNotFound" => PipelinesSyncPipelineResponseErrorCode2.PipelineNotFound,
                _ => null,
            };
        }
    }
}