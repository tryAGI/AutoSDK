//HintName: G.Models.GetResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetResponseDtoStatus
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
    public static class GetResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseDtoStatus value)
        {
            return value switch
            {
                GetResponseDtoStatus.Created => "created",
                GetResponseDtoStatus.Done => "done",
                GetResponseDtoStatus.Error => "error",
                GetResponseDtoStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetResponseDtoStatus.Created,
                "done" => GetResponseDtoStatus.Done,
                "error" => GetResponseDtoStatus.Error,
                "validating" => GetResponseDtoStatus.Validating,
                _ => null,
            };
        }
    }
}