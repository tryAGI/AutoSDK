//HintName: G.Models.ContainerRunErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ContainerRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        CudaError,
        /// <summary>
        /// 
        /// </summary>
        CudaOom,
        /// <summary>
        /// 
        /// </summary>
        InputError,
        /// <summary>
        /// 
        /// </summary>
        Oom,
        /// <summary>
        /// 
        /// </summary>
        PipelineError,
        /// <summary>
        /// 
        /// </summary>
        PipelineLoading,
        /// <summary>
        /// 
        /// </summary>
        StartupError,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerRunErrorType value)
        {
            return value switch
            {
                ContainerRunErrorType.CudaError => "cuda_error",
                ContainerRunErrorType.CudaOom => "cuda_oom",
                ContainerRunErrorType.InputError => "input_error",
                ContainerRunErrorType.Oom => "oom",
                ContainerRunErrorType.PipelineError => "pipeline_error",
                ContainerRunErrorType.PipelineLoading => "pipeline_loading",
                ContainerRunErrorType.StartupError => "startup_error",
                ContainerRunErrorType.Timeout => "timeout",
                ContainerRunErrorType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "cuda_error" => ContainerRunErrorType.CudaError,
                "cuda_oom" => ContainerRunErrorType.CudaOom,
                "input_error" => ContainerRunErrorType.InputError,
                "oom" => ContainerRunErrorType.Oom,
                "pipeline_error" => ContainerRunErrorType.PipelineError,
                "pipeline_loading" => ContainerRunErrorType.PipelineLoading,
                "startup_error" => ContainerRunErrorType.StartupError,
                "timeout" => ContainerRunErrorType.Timeout,
                "unknown" => ContainerRunErrorType.Unknown,
                _ => null,
            };
        }
    }
}