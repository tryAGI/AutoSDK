//HintName: G.Models.EntityDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EntityDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="company")]
        Company,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="person")]
        Person,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityDiscriminatorType value)
        {
            return value switch
            {
                EntityDiscriminatorType.Company => "company",
                EntityDiscriminatorType.Person => "person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "company" => EntityDiscriminatorType.Company,
                "person" => EntityDiscriminatorType.Person,
                _ => null,
            };
        }
    }
}