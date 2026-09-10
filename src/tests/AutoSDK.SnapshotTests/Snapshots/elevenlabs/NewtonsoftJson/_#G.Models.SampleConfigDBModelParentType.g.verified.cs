//HintName: G.Models.SampleConfigDBModelParentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SampleConfigDBModelParentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="collection")]
        Collection,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SampleConfigDBModelParentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SampleConfigDBModelParentType value)
        {
            return value switch
            {
                SampleConfigDBModelParentType.Collection => "collection",
                SampleConfigDBModelParentType.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SampleConfigDBModelParentType? ToEnum(string value)
        {
            return value switch
            {
                "collection" => SampleConfigDBModelParentType.Collection,
                "read" => SampleConfigDBModelParentType.Read,
                _ => null,
            };
        }
    }
}