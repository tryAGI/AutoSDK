//HintName: G.Models.CreateEndCallToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "endCall" for End Call tool.
    /// </summary>
    public enum CreateEndCallToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEndCallToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEndCallToolDTOType value)
        {
            return value switch
            {
                CreateEndCallToolDTOType.EndCall => "endCall",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEndCallToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "endCall" => CreateEndCallToolDTOType.EndCall,
                _ => null,
            };
        }
    }
}