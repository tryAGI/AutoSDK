//HintName: G.Models.ConsentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsentStatus
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
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConsentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsentStatus value)
        {
            return value switch
            {
                ConsentStatus.Created => "created",
                ConsentStatus.Done => "done",
                ConsentStatus.Error => "error",
                ConsentStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsentStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => ConsentStatus.Created,
                "done" => ConsentStatus.Done,
                "error" => ConsentStatus.Error,
                "validating" => ConsentStatus.Validating,
                _ => null,
            };
        }
    }
}