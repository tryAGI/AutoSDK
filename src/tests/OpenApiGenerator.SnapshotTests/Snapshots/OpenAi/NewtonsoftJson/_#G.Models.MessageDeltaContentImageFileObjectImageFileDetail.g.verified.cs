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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaContentImageFileObjectImageFileDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaContentImageFileObjectImageFileDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => MessageDeltaContentImageFileObjectImageFileDetail.Auto,
                "low" => MessageDeltaContentImageFileObjectImageFileDetail.Low,
                "high" => MessageDeltaContentImageFileObjectImageFileDetail.High,
                _ => null,
            };
        }
    }
}