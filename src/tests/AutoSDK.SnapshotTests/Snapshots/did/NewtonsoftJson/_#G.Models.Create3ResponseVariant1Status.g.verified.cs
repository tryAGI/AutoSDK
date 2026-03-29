//HintName: G.Models.Create3ResponseVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create3ResponseVariant1Status
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
    public static class Create3ResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3ResponseVariant1Status value)
        {
            return value switch
            {
                Create3ResponseVariant1Status.Created => "created",
                Create3ResponseVariant1Status.Done => "done",
                Create3ResponseVariant1Status.Error => "error",
                Create3ResponseVariant1Status.Rejected => "rejected",
                Create3ResponseVariant1Status.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3ResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "created" => Create3ResponseVariant1Status.Created,
                "done" => Create3ResponseVariant1Status.Done,
                "error" => Create3ResponseVariant1Status.Error,
                "rejected" => Create3ResponseVariant1Status.Rejected,
                "started" => Create3ResponseVariant1Status.Started,
                _ => null,
            };
        }
    }
}