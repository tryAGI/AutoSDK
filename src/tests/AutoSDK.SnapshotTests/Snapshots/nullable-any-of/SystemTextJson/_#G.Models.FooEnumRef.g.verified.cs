//HintName: G.Models.FooEnumRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FooEnumRef
    {
        /// <summary>
        /// 
        /// </summary>
        A,
        /// <summary>
        /// 
        /// </summary>
        B,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FooEnumRefExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FooEnumRef value)
        {
            return value switch
            {
                FooEnumRef.A => "a",
                FooEnumRef.B => "b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FooEnumRef? ToEnum(string value)
        {
            return value switch
            {
                "a" => FooEnumRef.A,
                "b" => FooEnumRef.B,
                _ => null,
            };
        }
    }
}