//HintName: G.Models.IngestionEventVariant9Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IngestionEventVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="observation-create")]
        ObservationCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventVariant9Type value)
        {
            return value switch
            {
                IngestionEventVariant9Type.ObservationCreate => "observation-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "observation-create" => IngestionEventVariant9Type.ObservationCreate,
                _ => null,
            };
        }
    }
}