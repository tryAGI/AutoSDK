//HintName: G.Models.AssetResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssetResponseDtoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetResponseDtoStatus value)
        {
            return value switch
            {
                AssetResponseDtoStatus.Created => "created",
                AssetResponseDtoStatus.Done => "done",
                AssetResponseDtoStatus.Error => "error",
                AssetResponseDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => AssetResponseDtoStatus.Created,
                "done" => AssetResponseDtoStatus.Done,
                "error" => AssetResponseDtoStatus.Error,
                "started" => AssetResponseDtoStatus.Started,
                _ => null,
            };
        }
    }
}