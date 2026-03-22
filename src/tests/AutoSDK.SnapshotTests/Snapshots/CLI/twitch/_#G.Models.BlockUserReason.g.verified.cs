//HintName: G.Models.BlockUserReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BlockUserReason
    {
        /// <summary>
        /// 
        /// </summary>
        Harassment,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlockUserReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlockUserReason value)
        {
            return value switch
            {
                BlockUserReason.Harassment => "harassment",
                BlockUserReason.Other => "other",
                BlockUserReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlockUserReason? ToEnum(string value)
        {
            return value switch
            {
                "harassment" => BlockUserReason.Harassment,
                "other" => BlockUserReason.Other,
                "spam" => BlockUserReason.Spam,
                _ => null,
            };
        }
    }
}