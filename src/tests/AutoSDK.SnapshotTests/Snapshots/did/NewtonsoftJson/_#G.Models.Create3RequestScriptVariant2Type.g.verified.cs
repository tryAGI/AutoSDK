//HintName: G.Models.Create3RequestScriptVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create3RequestScriptVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create3RequestScriptVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3RequestScriptVariant2Type value)
        {
            return value switch
            {
                Create3RequestScriptVariant2Type.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3RequestScriptVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "audio" => Create3RequestScriptVariant2Type.Audio,
                _ => null,
            };
        }
    }
}