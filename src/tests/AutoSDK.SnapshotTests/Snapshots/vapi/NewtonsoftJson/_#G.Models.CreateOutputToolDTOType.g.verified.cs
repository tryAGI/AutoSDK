//HintName: G.Models.CreateOutputToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "output" for Output tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateOutputToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output")]
        Output,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOutputToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOutputToolDTOType value)
        {
            return value switch
            {
                CreateOutputToolDTOType.Output => "output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOutputToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "output" => CreateOutputToolDTOType.Output,
                _ => null,
            };
        }
    }
}