//HintName: G.Models.GetGroupResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the group
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetGroupResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partial-done")]
        PartialDone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validating")]
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetGroupResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGroupResponseStatus2 value)
        {
            return value switch
            {
                GetGroupResponseStatus2.Created => "created",
                GetGroupResponseStatus2.Done => "done",
                GetGroupResponseStatus2.Error => "error",
                GetGroupResponseStatus2.PartialDone => "partial-done",
                GetGroupResponseStatus2.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGroupResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetGroupResponseStatus2.Created,
                "done" => GetGroupResponseStatus2.Done,
                "error" => GetGroupResponseStatus2.Error,
                "partial-done" => GetGroupResponseStatus2.PartialDone,
                "validating" => GetGroupResponseStatus2.Validating,
                _ => null,
            };
        }
    }
}