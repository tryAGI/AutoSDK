//HintName: G.Models.PostCliCreateSessionResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the session<br/>
    /// Example: pending
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostCliCreateSessionResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="linked")]
        Linked,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostCliCreateSessionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCliCreateSessionResponseStatus value)
        {
            return value switch
            {
                PostCliCreateSessionResponseStatus.Linked => "linked",
                PostCliCreateSessionResponseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCliCreateSessionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "linked" => PostCliCreateSessionResponseStatus.Linked,
                "pending" => PostCliCreateSessionResponseStatus.Pending,
                _ => null,
            };
        }
    }
}