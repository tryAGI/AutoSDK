//HintName: G.Models.ListInstructionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: initial
    /// </summary>
    public enum ListInstructionsType
    {
        /// <summary>
        /// 
        /// </summary>
        Initial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListInstructionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListInstructionsType value)
        {
            return value switch
            {
                ListInstructionsType.Initial => "initial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListInstructionsType? ToEnum(string value)
        {
            return value switch
            {
                "initial" => ListInstructionsType.Initial,
                _ => null,
            };
        }
    }
}