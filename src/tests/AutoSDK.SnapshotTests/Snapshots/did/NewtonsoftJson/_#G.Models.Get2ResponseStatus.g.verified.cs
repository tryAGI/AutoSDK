//HintName: G.Models.Get2ResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Get2ResponseStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Get2ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Get2ResponseStatus value)
        {
            return value switch
            {
                Get2ResponseStatus.Created => "created",
                Get2ResponseStatus.Done => "done",
                Get2ResponseStatus.Error => "error",
                Get2ResponseStatus.Rejected => "rejected",
                Get2ResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Get2ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => Get2ResponseStatus.Created,
                "done" => Get2ResponseStatus.Done,
                "error" => Get2ResponseStatus.Error,
                "rejected" => Get2ResponseStatus.Rejected,
                "started" => Get2ResponseStatus.Started,
                _ => null,
            };
        }
    }
}