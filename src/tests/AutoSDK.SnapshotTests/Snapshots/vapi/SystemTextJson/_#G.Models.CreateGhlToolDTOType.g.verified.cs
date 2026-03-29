//HintName: G.Models.CreateGhlToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "ghl" for GHL tool.
    /// </summary>
    public enum CreateGhlToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Ghl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGhlToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGhlToolDTOType value)
        {
            return value switch
            {
                CreateGhlToolDTOType.Ghl => "ghl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGhlToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "ghl" => CreateGhlToolDTOType.Ghl,
                _ => null,
            };
        }
    }
}