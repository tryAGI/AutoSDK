//HintName: G.Models.GetGroupResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the group
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetGroupResponseStatus
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
    public static class GetGroupResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGroupResponseStatus value)
        {
            return value switch
            {
                GetGroupResponseStatus.Created => "created",
                GetGroupResponseStatus.Done => "done",
                GetGroupResponseStatus.Error => "error",
                GetGroupResponseStatus.PartialDone => "partial-done",
                GetGroupResponseStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGroupResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetGroupResponseStatus.Created,
                "done" => GetGroupResponseStatus.Done,
                "error" => GetGroupResponseStatus.Error,
                "partial-done" => GetGroupResponseStatus.PartialDone,
                "validating" => GetGroupResponseStatus.Validating,
                _ => null,
            };
        }
    }
}