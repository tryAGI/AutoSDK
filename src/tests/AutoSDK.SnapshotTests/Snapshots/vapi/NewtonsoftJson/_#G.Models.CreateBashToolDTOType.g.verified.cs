//HintName: G.Models.CreateBashToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "bash" for Bash tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateBashToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash")]
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBashToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBashToolDTOType value)
        {
            return value switch
            {
                CreateBashToolDTOType.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBashToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "bash" => CreateBashToolDTOType.Bash,
                _ => null,
            };
        }
    }
}