//HintName: G.Models.Sample.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Sample
    {
        /// <summary>
        /// 
        /// </summary>
        Random,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SampleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sample value)
        {
            return value switch
            {
                Sample.Random => "random",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sample? ToEnum(string value)
        {
            return value switch
            {
                "random" => Sample.Random,
                _ => null,
            };
        }
    }
}