//HintName: G.Models.GetCliGetSessionResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the session<br/>
    /// Example: pending
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetCliGetSessionResponseStatus
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
    public static class GetCliGetSessionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCliGetSessionResponseStatus value)
        {
            return value switch
            {
                GetCliGetSessionResponseStatus.Linked => "linked",
                GetCliGetSessionResponseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCliGetSessionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "linked" => GetCliGetSessionResponseStatus.Linked,
                "pending" => GetCliGetSessionResponseStatus.Pending,
                _ => null,
            };
        }
    }
}