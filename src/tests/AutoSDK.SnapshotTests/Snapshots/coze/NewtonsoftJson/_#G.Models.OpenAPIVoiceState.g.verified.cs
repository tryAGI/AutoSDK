//HintName: G.Models.OpenAPIVoiceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAPIVoiceState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cloned")]
        Cloned,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="init")]
        Init,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAPIVoiceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAPIVoiceState value)
        {
            return value switch
            {
                OpenAPIVoiceState.All => "all",
                OpenAPIVoiceState.Cloned => "cloned",
                OpenAPIVoiceState.Init => "init",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAPIVoiceState? ToEnum(string value)
        {
            return value switch
            {
                "all" => OpenAPIVoiceState.All,
                "cloned" => OpenAPIVoiceState.Cloned,
                "init" => OpenAPIVoiceState.Init,
                _ => null,
            };
        }
    }
}