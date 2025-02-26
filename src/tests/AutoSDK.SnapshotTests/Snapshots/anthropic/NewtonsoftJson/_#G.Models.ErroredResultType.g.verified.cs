//HintName: G.Models.ErroredResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: errored
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ErroredResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="errored")]
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErroredResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErroredResultType value)
        {
            return value switch
            {
                ErroredResultType.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErroredResultType? ToEnum(string value)
        {
            return value switch
            {
                "errored" => ErroredResultType.Errored,
                _ => null,
            };
        }
    }
}