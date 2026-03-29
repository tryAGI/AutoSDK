//HintName: G.Models.CreateResponseResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `response`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateResponseResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response")]
        Response,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseResponseObject value)
        {
            return value switch
            {
                CreateResponseResponseObject.Response => "response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "response" => CreateResponseResponseObject.Response,
                _ => null,
            };
        }
    }
}