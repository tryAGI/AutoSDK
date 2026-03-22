//HintName: G.Models.PipelineState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelineState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container_failed")]
        ContainerFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="load_failed")]
        LoadFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="loaded")]
        Loaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="loading")]
        Loading,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_loaded")]
        NotLoaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup_failed")]
        StartupFailed,
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
                PipelineState.ContainerFailed => "container_failed",
                PipelineState.Failed => "failed",
                PipelineState.LoadFailed => "load_failed",
                PipelineState.Loaded => "loaded",
                PipelineState.Loading => "loading",
                PipelineState.NotLoaded => "not_loaded",
                PipelineState.StartupFailed => "startup_failed",
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
                "container_failed" => PipelineState.ContainerFailed,
                "failed" => PipelineState.Failed,
                "load_failed" => PipelineState.LoadFailed,
                "loaded" => PipelineState.Loaded,
                "loading" => PipelineState.Loading,
                "not_loaded" => PipelineState.NotLoaded,
                "startup_failed" => PipelineState.StartupFailed,
                _ => null,
            };
        }
    }
}