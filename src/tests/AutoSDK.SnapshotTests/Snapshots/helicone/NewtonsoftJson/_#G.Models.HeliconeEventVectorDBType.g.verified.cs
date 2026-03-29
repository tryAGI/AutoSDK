//HintName: G.Models.HeliconeEventVectorDBType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HeliconeEventVectorDBType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vector_db")]
        VectorDb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeliconeEventVectorDBTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeliconeEventVectorDBType value)
        {
            return value switch
            {
                HeliconeEventVectorDBType.VectorDb => "vector_db",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeliconeEventVectorDBType? ToEnum(string value)
        {
            return value switch
            {
                "vector_db" => HeliconeEventVectorDBType.VectorDb,
                _ => null,
            };
        }
    }
}