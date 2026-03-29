//HintName: G.Models.ReturnToolItemToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReturnToolItemToolType
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
    public static class ReturnToolItemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnToolItemToolType value)
        {
            return value switch
            {
                ReturnToolItemToolType.Builtin => "BUILTIN",
                ReturnToolItemToolType.Function => "FUNCTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnToolItemToolType? ToEnum(string value)
        {
            return value switch
            {
                "BUILTIN" => ReturnToolItemToolType.Builtin,
                "FUNCTION" => ReturnToolItemToolType.Function,
                _ => null,
            };
        }
    }
}