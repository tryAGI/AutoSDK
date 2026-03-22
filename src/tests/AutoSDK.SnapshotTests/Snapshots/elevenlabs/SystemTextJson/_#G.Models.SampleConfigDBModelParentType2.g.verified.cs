//HintName: G.Models.SampleConfigDBModelParentType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SampleConfigDBModelParentType2
    {
        /// <summary>
        /// 
        /// </summary>
        Collection,
        /// <summary>
        /// 
        /// </summary>
        Read,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SampleConfigDBModelParentType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SampleConfigDBModelParentType2 value)
        {
            return value switch
            {
                SampleConfigDBModelParentType2.Collection => "collection",
                SampleConfigDBModelParentType2.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SampleConfigDBModelParentType2? ToEnum(string value)
        {
            return value switch
            {
                "collection" => SampleConfigDBModelParentType2.Collection,
                "read" => SampleConfigDBModelParentType2.Read,
                _ => null,
            };
        }
    }
}