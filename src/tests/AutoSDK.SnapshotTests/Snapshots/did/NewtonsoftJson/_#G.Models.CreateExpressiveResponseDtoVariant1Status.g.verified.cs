//HintName: G.Models.CreateExpressiveResponseDtoVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateExpressiveResponseDtoVariant1Status
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
    public static class CreateExpressiveResponseDtoVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressiveResponseDtoVariant1Status value)
        {
            return value switch
            {
                CreateExpressiveResponseDtoVariant1Status.Created => "created",
                CreateExpressiveResponseDtoVariant1Status.Done => "done",
                CreateExpressiveResponseDtoVariant1Status.Error => "error",
                CreateExpressiveResponseDtoVariant1Status.Rejected => "rejected",
                CreateExpressiveResponseDtoVariant1Status.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressiveResponseDtoVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateExpressiveResponseDtoVariant1Status.Created,
                "done" => CreateExpressiveResponseDtoVariant1Status.Done,
                "error" => CreateExpressiveResponseDtoVariant1Status.Error,
                "rejected" => CreateExpressiveResponseDtoVariant1Status.Rejected,
                "started" => CreateExpressiveResponseDtoVariant1Status.Started,
                _ => null,
            };
        }
    }
}