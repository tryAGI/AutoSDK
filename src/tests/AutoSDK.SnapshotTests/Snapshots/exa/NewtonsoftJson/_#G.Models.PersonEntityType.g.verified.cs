//HintName: G.Models.PersonEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Entity type discriminator.<br/>
    /// Example: person
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PersonEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="person")]
        Person,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersonEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersonEntityType value)
        {
            return value switch
            {
                PersonEntityType.Person => "person",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersonEntityType? ToEnum(string value)
        {
            return value switch
            {
                "person" => PersonEntityType.Person,
                _ => null,
            };
        }
    }
}