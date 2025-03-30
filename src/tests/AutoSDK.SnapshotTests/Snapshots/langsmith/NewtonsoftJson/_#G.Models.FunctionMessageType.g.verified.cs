//HintName: G.Models.FunctionMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: function
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionMessageType value)
        {
            return value switch
            {
                FunctionMessageType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionMessageType? ToEnum(string value)
        {
            return value switch
            {
                "function" => FunctionMessageType.Function,
                _ => null,
            };
        }
    }
}