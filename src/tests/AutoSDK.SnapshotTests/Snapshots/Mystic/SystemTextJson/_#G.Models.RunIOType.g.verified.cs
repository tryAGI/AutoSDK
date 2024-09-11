//HintName: G.Models.RunIOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum RunIOType
    {
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        Fp,
        /// <summary>
        /// 
        /// </summary>
        Dictionary,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Array,
        /// <summary>
        /// 
        /// </summary>
        Pkl,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Stream,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunIOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunIOType value)
        {
            return value switch
            {
                RunIOType.Integer => "integer",
                RunIOType.String => "string",
                RunIOType.Fp => "fp",
                RunIOType.Dictionary => "dictionary",
                RunIOType.Boolean => "boolean",
                RunIOType.None => "none",
                RunIOType.Array => "array",
                RunIOType.Pkl => "pkl",
                RunIOType.File => "file",
                RunIOType.Stream => "stream",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunIOType? ToEnum(string value)
        {
            return value switch
            {
                "integer" => RunIOType.Integer,
                "string" => RunIOType.String,
                "fp" => RunIOType.Fp,
                "dictionary" => RunIOType.Dictionary,
                "boolean" => RunIOType.Boolean,
                "none" => RunIOType.None,
                "array" => RunIOType.Array,
                "pkl" => RunIOType.Pkl,
                "file" => RunIOType.File,
                "stream" => RunIOType.Stream,
                _ => null,
            };
        }
    }
}