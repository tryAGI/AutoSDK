//HintName: G.Models.ReturnUserDefinedToolToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReturnUserDefinedToolToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Builtin,
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnUserDefinedToolToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnUserDefinedToolToolType value)
        {
            return value switch
            {
                ReturnUserDefinedToolToolType.Builtin => "BUILTIN",
                ReturnUserDefinedToolToolType.Function => "FUNCTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnUserDefinedToolToolType? ToEnum(string value)
        {
            return value switch
            {
                "BUILTIN" => ReturnUserDefinedToolToolType.Builtin,
                "FUNCTION" => ReturnUserDefinedToolToolType.Function,
                _ => null,
            };
        }
    }
}