//HintName: G.Models.CreateGoHighLevelContactCreateToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.contact.create" for GoHighLevel Contact Create tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateGoHighLevelContactCreateToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gohighlevel.contact.create")]
        GohighlevelContactCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGoHighLevelContactCreateToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoHighLevelContactCreateToolDTOType value)
        {
            return value switch
            {
                CreateGoHighLevelContactCreateToolDTOType.GohighlevelContactCreate => "gohighlevel.contact.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoHighLevelContactCreateToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.contact.create" => CreateGoHighLevelContactCreateToolDTOType.GohighlevelContactCreate,
                _ => null,
            };
        }
    }
}