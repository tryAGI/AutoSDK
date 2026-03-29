//HintName: G.Models.IngestionEventVariant7Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IngestionEventVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        EventCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventVariant7Type value)
        {
            return value switch
            {
                IngestionEventVariant7Type.EventCreate => "event-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "event-create" => IngestionEventVariant7Type.EventCreate,
                _ => null,
            };
        }
    }
}