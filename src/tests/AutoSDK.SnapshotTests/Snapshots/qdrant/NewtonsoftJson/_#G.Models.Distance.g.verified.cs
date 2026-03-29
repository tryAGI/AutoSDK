//HintName: G.Models.Distance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of internal tags, build from payload Distance function types used to compare vectors
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Distance
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Cosine")]
        Cosine,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Dot")]
        Dot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Euclid")]
        Euclid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Manhattan")]
        Manhattan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DistanceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Distance value)
        {
            return value switch
            {
                Distance.Cosine => "Cosine",
                Distance.Dot => "Dot",
                Distance.Euclid => "Euclid",
                Distance.Manhattan => "Manhattan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Distance? ToEnum(string value)
        {
            return value switch
            {
                "Cosine" => Distance.Cosine,
                "Dot" => Distance.Dot,
                "Euclid" => Distance.Euclid,
                "Manhattan" => Distance.Manhattan,
                _ => null,
            };
        }
    }
}