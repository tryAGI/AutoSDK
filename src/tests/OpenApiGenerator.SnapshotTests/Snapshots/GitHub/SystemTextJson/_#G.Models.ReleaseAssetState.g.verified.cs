//HintName: G.Models.ReleaseAssetState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the release asset.
    /// </summary>
    public enum ReleaseAssetState
    {
        /// <summary>
        /// 
        /// </summary>
        Uploaded,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReleaseAssetStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReleaseAssetState value)
        {
            return value switch
            {
                ReleaseAssetState.Uploaded => "uploaded",
                ReleaseAssetState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReleaseAssetState ToEnum(string value)
        {
            return value switch
            {
                "uploaded" => ReleaseAssetState.Uploaded,
                "open" => ReleaseAssetState.Open,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}