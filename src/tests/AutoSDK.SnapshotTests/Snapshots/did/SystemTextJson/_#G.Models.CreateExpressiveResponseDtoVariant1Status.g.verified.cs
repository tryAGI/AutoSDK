//HintName: G.Models.CreateExpressiveResponseDtoVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateExpressiveResponseDtoVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
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