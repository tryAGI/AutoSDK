//HintName: G.Models.Get1ResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Get1ResponseStatus
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
    public static class Get1ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Get1ResponseStatus value)
        {
            return value switch
            {
                Get1ResponseStatus.Created => "created",
                Get1ResponseStatus.Done => "done",
                Get1ResponseStatus.Error => "error",
                Get1ResponseStatus.Rejected => "rejected",
                Get1ResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Get1ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => Get1ResponseStatus.Created,
                "done" => Get1ResponseStatus.Done,
                "error" => Get1ResponseStatus.Error,
                "rejected" => Get1ResponseStatus.Rejected,
                "started" => Get1ResponseStatus.Started,
                _ => null,
            };
        }
    }
}