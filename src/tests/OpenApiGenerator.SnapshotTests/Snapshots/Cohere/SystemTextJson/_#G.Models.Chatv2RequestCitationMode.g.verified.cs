//HintName: G.Models.Chatv2RequestCitationMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defaults to `"accurate"`.<br/>
    /// Dictates the approach taken to generating citations as part of the RAG flow by allowing the user to specify whether they want `"accurate"` results, `"fast"` results or no results.
    /// </summary>
    public enum Chatv2RequestCitationMode
    {
        /// <summary>
        /// 
        /// </summary>
        FAST,
        /// <summary>
        /// 
        /// </summary>
        ACCURATE,
        /// <summary>
        /// 
        /// </summary>
        OFF,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Chatv2RequestCitationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Chatv2RequestCitationMode value)
        {
            return value switch
            {
                Chatv2RequestCitationMode.FAST => "FAST",
                Chatv2RequestCitationMode.ACCURATE => "ACCURATE",
                Chatv2RequestCitationMode.OFF => "OFF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Chatv2RequestCitationMode? ToEnum(string value)
        {
            return value switch
            {
                "FAST" => Chatv2RequestCitationMode.FAST,
                "ACCURATE" => Chatv2RequestCitationMode.ACCURATE,
                "OFF" => Chatv2RequestCitationMode.OFF,
                _ => null,
            };
        }
    }
}