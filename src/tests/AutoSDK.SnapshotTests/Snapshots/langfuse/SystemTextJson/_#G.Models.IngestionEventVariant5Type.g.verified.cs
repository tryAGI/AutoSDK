//HintName: G.Models.IngestionEventVariant5Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IngestionEventVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        GenerationCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventVariant5Type value)
        {
            return value switch
            {
                IngestionEventVariant5Type.GenerationCreate => "generation-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "generation-create" => IngestionEventVariant5Type.GenerationCreate,
                _ => null,
            };
        }
    }
}