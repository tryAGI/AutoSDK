//HintName: G.Models.SucceededResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: succeeded
    /// </summary>
    public enum SucceededResultType
    {
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SucceededResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SucceededResultType value)
        {
            return value switch
            {
                SucceededResultType.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SucceededResultType? ToEnum(string value)
        {
            return value switch
            {
                "succeeded" => SucceededResultType.Succeeded,
                _ => null,
            };
        }
    }
}