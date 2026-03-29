//HintName: G.Models.CreateGoHighLevelContactGetToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "gohighlevel.contact.get" for GoHighLevel Contact Get tool.
    /// </summary>
    public enum CreateGoHighLevelContactGetToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        GohighlevelContactGet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGoHighLevelContactGetToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoHighLevelContactGetToolDTOType value)
        {
            return value switch
            {
                CreateGoHighLevelContactGetToolDTOType.GohighlevelContactGet => "gohighlevel.contact.get",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoHighLevelContactGetToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel.contact.get" => CreateGoHighLevelContactGetToolDTOType.GohighlevelContactGet,
                _ => null,
            };
        }
    }
}