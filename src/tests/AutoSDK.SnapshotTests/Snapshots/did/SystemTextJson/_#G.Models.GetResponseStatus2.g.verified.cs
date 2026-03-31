//HintName: G.Models.GetResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetResponseStatus2
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
    public static class GetResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseStatus2 value)
        {
            return value switch
            {
                GetResponseStatus2.Created => "created",
                GetResponseStatus2.Done => "done",
                GetResponseStatus2.Error => "error",
                GetResponseStatus2.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetResponseStatus2.Created,
                "done" => GetResponseStatus2.Done,
                "error" => GetResponseStatus2.Error,
                "validating" => GetResponseStatus2.Validating,
                _ => null,
            };
        }
    }
}