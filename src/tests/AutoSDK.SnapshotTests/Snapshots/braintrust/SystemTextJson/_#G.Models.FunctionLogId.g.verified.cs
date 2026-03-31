//HintName: G.Models.FunctionLogId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A literal 'p' which identifies the object as a project prompt
    /// </summary>
    public enum FunctionLogId
    {
        /// <summary>
        /// 
        /// </summary>
        P,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionLogIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionLogId value)
        {
            return value switch
            {
                FunctionLogId.P => "p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionLogId? ToEnum(string value)
        {
            return value switch
            {
                "p" => FunctionLogId.P,
                _ => null,
            };
        }
    }
}