//HintName: G.Models.MessageDeltaContentImageFileObjectImageFileDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the detail level of the image if specified by the user. `low` uses fewer tokens, you can opt in to high resolution using `high`.
    /// <br/>Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDeltaContentImageFileObjectImageFileDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
    }

    public static class MessageDeltaContentImageFileObjectImageFileDetailExtensions
    {
        public static string ToValueString(this MessageDeltaContentImageFileObjectImageFileDetail value)
        {
            return value switch
            {
                MessageDeltaContentImageFileObjectImageFileDetail.Auto => "auto",
                MessageDeltaContentImageFileObjectImageFileDetail.Low => "low",
                MessageDeltaContentImageFileObjectImageFileDetail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentImageFileObjectImageFileDetail ToEnum(string value)
        {
            return value switch
            {
                "auto" => MessageDeltaContentImageFileObjectImageFileDetail.Auto,
                "low" => MessageDeltaContentImageFileObjectImageFileDetail.Low,
                "high" => MessageDeltaContentImageFileObjectImageFileDetail.High,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentImageFileObjectImageFileDetail ToEnum(int value)
        {
            return value switch
            {
                0 => MessageDeltaContentImageFileObjectImageFileDetail.Auto,
                1 => MessageDeltaContentImageFileObjectImageFileDetail.Low,
                2 => MessageDeltaContentImageFileObjectImageFileDetail.High,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}