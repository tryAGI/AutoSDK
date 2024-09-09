//HintName: G.Models.SummaryMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SummaryMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="segments")]
        Segments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="guided")]
        Guided,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fullDocument")]
        FullDocument,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryMethod value)
        {
            return value switch
            {
                SummaryMethod.Segments => "segments",
                SummaryMethod.Guided => "guided",
                SummaryMethod.FullDocument => "fullDocument",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryMethod? ToEnum(string value)
        {
            return value switch
            {
                "segments" => SummaryMethod.Segments,
                "guided" => SummaryMethod.Guided,
                "fullDocument" => SummaryMethod.FullDocument,
                _ => null,
            };
        }
    }
}