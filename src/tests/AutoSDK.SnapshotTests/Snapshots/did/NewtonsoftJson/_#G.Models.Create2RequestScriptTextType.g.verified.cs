//HintName: G.Models.Create2RequestScriptTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create2RequestScriptTextType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create2RequestScriptTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create2RequestScriptTextType value)
        {
            return value switch
            {
                Create2RequestScriptTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create2RequestScriptTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => Create2RequestScriptTextType.Text,
                _ => null,
            };
        }
    }
}