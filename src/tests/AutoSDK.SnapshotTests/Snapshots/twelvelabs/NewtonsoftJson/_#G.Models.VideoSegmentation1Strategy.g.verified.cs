//HintName: G.Models.VideoSegmentation1Strategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VideoSegmentation1Strategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoSegmentation1StrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSegmentation1Strategy value)
        {
            return value switch
            {
                VideoSegmentation1Strategy.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSegmentation1Strategy? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => VideoSegmentation1Strategy.Fixed,
                _ => null,
            };
        }
    }
}