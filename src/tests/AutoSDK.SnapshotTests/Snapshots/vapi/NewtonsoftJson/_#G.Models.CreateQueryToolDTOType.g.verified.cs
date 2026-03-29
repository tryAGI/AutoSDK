//HintName: G.Models.CreateQueryToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "query" for Query tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateQueryToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="query")]
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateQueryToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateQueryToolDTOType value)
        {
            return value switch
            {
                CreateQueryToolDTOType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateQueryToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "query" => CreateQueryToolDTOType.Query,
                _ => null,
            };
        }
    }
}