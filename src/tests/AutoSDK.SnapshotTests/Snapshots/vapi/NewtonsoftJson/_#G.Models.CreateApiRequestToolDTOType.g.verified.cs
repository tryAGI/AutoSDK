//HintName: G.Models.CreateApiRequestToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "apiRequest" for API request tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateApiRequestToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apiRequest")]
        ApiRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateApiRequestToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiRequestToolDTOType value)
        {
            return value switch
            {
                CreateApiRequestToolDTOType.ApiRequest => "apiRequest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiRequestToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => CreateApiRequestToolDTOType.ApiRequest,
                _ => null,
            };
        }
    }
}