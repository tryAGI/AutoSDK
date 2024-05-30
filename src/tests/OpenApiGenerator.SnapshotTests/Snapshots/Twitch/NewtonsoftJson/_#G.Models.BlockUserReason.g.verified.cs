//HintName: G.Models.BlockUserReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BlockUserReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="harassment")]
        Harassment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spam")]
        Spam,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
    }

    public static class BlockUserReasonExtensions
    {
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
        public static BlockUserReason ToEnum(string value)
        {
            return value switch
            {
                "harassment" => BlockUserReason.Harassment,
                "spam" => BlockUserReason.Spam,
                "other" => BlockUserReason.Other,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static BlockUserReason ToEnum(int value)
        {
            return value switch
            {
                0 => BlockUserReason.Harassment,
                1 => BlockUserReason.Spam,
                2 => BlockUserReason.Other,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}