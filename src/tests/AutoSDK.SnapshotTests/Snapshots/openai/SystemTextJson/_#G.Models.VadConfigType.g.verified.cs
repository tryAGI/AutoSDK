//HintName: G.Models.VadConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be set to `server_vad` to enable manual chunking using server side VAD.
    /// </summary>
    public enum VadConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        ServerVad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VadConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VadConfigType value)
        {
            return value switch
            {
                VadConfigType.ServerVad => "server_vad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VadConfigType? ToEnum(string value)
        {
            return value switch
            {
                "server_vad" => VadConfigType.ServerVad,
                _ => null,
            };
        }
    }
}