//HintName: G.Models.HeliconeEventDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HeliconeEventDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Data,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeliconeEventDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeliconeEventDataType value)
        {
            return value switch
            {
                HeliconeEventDataType.Data => "data",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeliconeEventDataType? ToEnum(string value)
        {
            return value switch
            {
                "data" => HeliconeEventDataType.Data,
                _ => null,
            };
        }
    }
}