//HintName: G.Models.ConvertSpecTo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConvertSpecTo
    {
        /// <summary>
        /// 
        /// </summary>
        Bool,
        /// <summary>
        /// 
        /// </summary>
        Double,
        /// <summary>
        /// 
        /// </summary>
        Exists,
        /// <summary>
        /// 
        /// </summary>
        Int,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConvertSpecToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvertSpecTo value)
        {
            return value switch
            {
                ConvertSpecTo.Bool => "bool",
                ConvertSpecTo.Double => "double",
                ConvertSpecTo.Exists => "exists",
                ConvertSpecTo.Int => "int",
                ConvertSpecTo.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvertSpecTo? ToEnum(string value)
        {
            return value switch
            {
                "bool" => ConvertSpecTo.Bool,
                "double" => ConvertSpecTo.Double,
                "exists" => ConvertSpecTo.Exists,
                "int" => ConvertSpecTo.Int,
                "string" => ConvertSpecTo.String,
                _ => null,
            };
        }
    }
}