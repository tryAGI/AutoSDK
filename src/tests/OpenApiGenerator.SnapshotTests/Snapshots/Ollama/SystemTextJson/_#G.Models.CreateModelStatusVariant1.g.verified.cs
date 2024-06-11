//HintName: G.Models.CreateModelStatusVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelStatusVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        CreatingSystemLayer,
        /// <summary>
        /// 
        /// </summary>
        ParsingModelfile,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelStatusVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelStatusVariant1 value)
        {
            return value switch
            {
                CreateModelStatusVariant1.CreatingSystemLayer => "creating system layer",
                CreateModelStatusVariant1.ParsingModelfile => "parsing modelfile",
                CreateModelStatusVariant1.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelStatusVariant1? ToEnum(string value)
        {
            return value switch
            {
                "creating system layer" => CreateModelStatusVariant1.CreatingSystemLayer,
                "parsing modelfile" => CreateModelStatusVariant1.ParsingModelfile,
                "success" => CreateModelStatusVariant1.Success,
                _ => null,
            };
        }
    }
}