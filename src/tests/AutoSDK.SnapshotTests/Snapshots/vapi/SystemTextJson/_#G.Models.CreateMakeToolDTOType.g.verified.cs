//HintName: G.Models.CreateMakeToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "make" for Make tool.
    /// </summary>
    public enum CreateMakeToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Make,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMakeToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMakeToolDTOType value)
        {
            return value switch
            {
                CreateMakeToolDTOType.Make => "make",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMakeToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "make" => CreateMakeToolDTOType.Make,
                _ => null,
            };
        }
    }
}