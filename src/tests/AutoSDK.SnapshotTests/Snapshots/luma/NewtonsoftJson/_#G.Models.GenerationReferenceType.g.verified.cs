//HintName: G.Models.GenerationReferenceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: generation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerationReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation")]
        Generation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationReferenceType value)
        {
            return value switch
            {
                GenerationReferenceType.Generation => "generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "generation" => GenerationReferenceType.Generation,
                _ => null,
            };
        }
    }
}