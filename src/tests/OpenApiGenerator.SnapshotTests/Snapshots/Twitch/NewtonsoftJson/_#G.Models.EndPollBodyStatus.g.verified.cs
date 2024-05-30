//HintName: G.Models.EndPollBodyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status to set the poll to. Possible case-sensitive values are:  
    ///   
    /// * TERMINATED — Ends the poll before the poll is scheduled to end. The poll remains publicly visible.
    /// * ARCHIVED — Ends the poll before the poll is scheduled to end, and then archives it so it's no longer publicly visible.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EndPollBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TERMINATED")]
        TERMINATED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ARCHIVED")]
        ARCHIVED,
    }

    public static class EndPollBodyStatusExtensions
    {
        public static string ToValueString(this EndPollBodyStatus value)
        {
            return value switch
            {
                EndPollBodyStatus.TERMINATED => "TERMINATED",
                EndPollBodyStatus.ARCHIVED => "ARCHIVED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EndPollBodyStatus ToEnum(string value)
        {
            return value switch
            {
                "TERMINATED" => EndPollBodyStatus.TERMINATED,
                "ARCHIVED" => EndPollBodyStatus.ARCHIVED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EndPollBodyStatus ToEnum(int value)
        {
            return value switch
            {
                0 => EndPollBodyStatus.TERMINATED,
                1 => EndPollBodyStatus.ARCHIVED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}