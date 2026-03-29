//HintName: G.Models.Create3RequestScriptVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create3RequestScriptVariant1Type
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
    public static class Create3RequestScriptVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3RequestScriptVariant1Type value)
        {
            return value switch
            {
                Create3RequestScriptVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3RequestScriptVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => Create3RequestScriptVariant1Type.Text,
                _ => null,
            };
        }
    }
}