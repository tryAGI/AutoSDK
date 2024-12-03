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
        Spam,
        /// <summary>
        /// 
        /// </summary>
        Other,
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
                BlockUserReason.Spam => "spam",
                BlockUserReason.Other => "other",
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
                "spam" => BlockUserReason.Spam,
                "other" => BlockUserReason.Other,
                _ => null,
            };
        }
    }
}