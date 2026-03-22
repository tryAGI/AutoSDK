//HintName: G.Models.RenderStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RenderStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenderStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenderStatus value)
        {
            return value switch
            {
                RenderStatus.Complete => "complete",
                RenderStatus.Failed => "failed",
                RenderStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenderStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => RenderStatus.Complete,
                "failed" => RenderStatus.Failed,
                "processing" => RenderStatus.Processing,
                _ => null,
            };
        }
    }
}