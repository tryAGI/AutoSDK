//HintName: G.Models.DubbedAssetCompleteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the dubbed video.<br/>
    /// Default Value: complete
    /// </summary>
    public enum DubbedAssetCompleteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbedAssetCompleteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbedAssetCompleteStatus value)
        {
            return value switch
            {
                DubbedAssetCompleteStatus.Complete => "complete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbedAssetCompleteStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => DubbedAssetCompleteStatus.Complete,
                _ => null,
            };
        }
    }
}