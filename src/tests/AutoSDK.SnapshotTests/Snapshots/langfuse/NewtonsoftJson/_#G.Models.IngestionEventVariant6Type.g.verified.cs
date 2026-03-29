//HintName: G.Models.IngestionEventVariant6Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IngestionEventVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation-update")]
        GenerationUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventVariant6Type value)
        {
            return value switch
            {
                IngestionEventVariant6Type.GenerationUpdate => "generation-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "generation-update" => IngestionEventVariant6Type.GenerationUpdate,
                _ => null,
            };
        }
    }
}