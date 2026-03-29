//HintName: G.Models.IndexesVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IndexesVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Plain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexesVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexesVariant1Type value)
        {
            return value switch
            {
                IndexesVariant1Type.Plain => "plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexesVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "plain" => IndexesVariant1Type.Plain,
                _ => null,
            };
        }
    }
}