//HintName: G.Models.AssetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssetStatus
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
    public static class AssetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetStatus value)
        {
            return value switch
            {
                AssetStatus.Created => "created",
                AssetStatus.Done => "done",
                AssetStatus.Error => "error",
                AssetStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => AssetStatus.Created,
                "done" => AssetStatus.Done,
                "error" => AssetStatus.Error,
                "started" => AssetStatus.Started,
                _ => null,
            };
        }
    }
}