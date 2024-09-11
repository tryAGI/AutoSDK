//HintName: G.Models.PipelineState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum PipelineState
    {
        /// <summary>
        /// 
        /// </summary>
        NotLoaded,
        /// <summary>
        /// 
        /// </summary>
        Loading,
        /// <summary>
        /// 
        /// </summary>
        Loaded,
        /// <summary>
        /// 
        /// </summary>
        LoadFailed,
        /// <summary>
        /// 
        /// </summary>
        StartupFailed,
        /// <summary>
        /// 
        /// </summary>
        ContainerFailed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineState value)
        {
            return value switch
            {
                PipelineState.NotLoaded => "not_loaded",
                PipelineState.Loading => "loading",
                PipelineState.Loaded => "loaded",
                PipelineState.LoadFailed => "load_failed",
                PipelineState.StartupFailed => "startup_failed",
                PipelineState.ContainerFailed => "container_failed",
                PipelineState.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineState? ToEnum(string value)
        {
            return value switch
            {
                "not_loaded" => PipelineState.NotLoaded,
                "loading" => PipelineState.Loading,
                "loaded" => PipelineState.Loaded,
                "load_failed" => PipelineState.LoadFailed,
                "startup_failed" => PipelineState.StartupFailed,
                "container_failed" => PipelineState.ContainerFailed,
                "failed" => PipelineState.Failed,
                _ => null,
            };
        }
    }
}