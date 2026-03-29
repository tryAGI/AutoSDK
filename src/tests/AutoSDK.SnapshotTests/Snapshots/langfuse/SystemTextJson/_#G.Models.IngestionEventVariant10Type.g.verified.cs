//HintName: G.Models.IngestionEventVariant10Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IngestionEventVariant10Type
    {
        /// <summary>
        /// 
        /// </summary>
        ObservationUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventVariant10Type value)
        {
            return value switch
            {
                IngestionEventVariant10Type.ObservationUpdate => "observation-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "observation-update" => IngestionEventVariant10Type.ObservationUpdate,
                _ => null,
            };
        }
    }
}