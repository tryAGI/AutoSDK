//HintName: G.Models.IngestionEventVariant4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IngestionEventVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="span-update")]
        SpanUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventVariant4Type value)
        {
            return value switch
            {
                IngestionEventVariant4Type.SpanUpdate => "span-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "span-update" => IngestionEventVariant4Type.SpanUpdate,
                _ => null,
            };
        }
    }
}