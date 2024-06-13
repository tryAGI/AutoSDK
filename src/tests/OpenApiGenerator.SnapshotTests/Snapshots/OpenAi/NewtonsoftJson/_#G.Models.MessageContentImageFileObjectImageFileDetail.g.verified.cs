//HintName: G.Models.MessageContentImageFileObjectImageFileDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the detail level of the image if specified by the user. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageContentImageFileObjectImageFileDetail
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
    public static class MessageContentImageFileObjectImageFileDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentImageFileObjectImageFileDetail value)
        {
            return value switch
            {
                MessageContentImageFileObjectImageFileDetail.Auto => "auto",
                MessageContentImageFileObjectImageFileDetail.Low => "low",
                MessageContentImageFileObjectImageFileDetail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentImageFileObjectImageFileDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => MessageContentImageFileObjectImageFileDetail.Auto,
                "low" => MessageContentImageFileObjectImageFileDetail.Low,
                "high" => MessageContentImageFileObjectImageFileDetail.High,
                _ => null,
            };
        }
    }
}