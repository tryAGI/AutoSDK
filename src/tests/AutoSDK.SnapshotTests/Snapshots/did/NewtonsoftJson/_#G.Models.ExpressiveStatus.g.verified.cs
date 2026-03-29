//HintName: G.Models.ExpressiveStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveStatus
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
    public static class ExpressiveStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveStatus value)
        {
            return value switch
            {
                ExpressiveStatus.Created => "created",
                ExpressiveStatus.Done => "done",
                ExpressiveStatus.Error => "error",
                ExpressiveStatus.Rejected => "rejected",
                ExpressiveStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => ExpressiveStatus.Created,
                "done" => ExpressiveStatus.Done,
                "error" => ExpressiveStatus.Error,
                "rejected" => ExpressiveStatus.Rejected,
                "started" => ExpressiveStatus.Started,
                _ => null,
            };
        }
    }
}