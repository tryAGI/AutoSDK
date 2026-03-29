//HintName: G.Models.DisplayAdTypeOf.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Types of the billboards:<br/>
    /// in_house (created by admins),<br/>
    /// community (created by an entity, appears on entity's content),<br/>
    /// external ( created by an entity, or a non-entity, can appear everywhere)<br/>
    /// Default Value: in_house
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DisplayAdTypeOf
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="community")]
        Community,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external")]
        External,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_house")]
        InHouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DisplayAdTypeOfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DisplayAdTypeOf value)
        {
            return value switch
            {
                DisplayAdTypeOf.Community => "community",
                DisplayAdTypeOf.External => "external",
                DisplayAdTypeOf.InHouse => "in_house",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DisplayAdTypeOf? ToEnum(string value)
        {
            return value switch
            {
                "community" => DisplayAdTypeOf.Community,
                "external" => DisplayAdTypeOf.External,
                "in_house" => DisplayAdTypeOf.InHouse,
                _ => null,
            };
        }
    }
}