//HintName: G.Models.ContainerRunErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContainerRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cuda_error")]
        CudaError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cuda_oom")]
        CudaOom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_error")]
        InputError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oom")]
        Oom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline_error")]
        PipelineError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pipeline_loading")]
        PipelineLoading,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup_error")]
        StartupError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timeout")]
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
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