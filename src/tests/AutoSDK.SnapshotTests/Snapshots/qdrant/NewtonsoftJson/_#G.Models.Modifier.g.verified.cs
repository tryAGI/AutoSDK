//HintName: G.Models.Modifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If used, include weight modification, which will be applied to sparse vectors at query time: None - no modification (default) Idf - inverse document frequency, based on statistics of the collection
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Modifier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="idf")]
        Idf,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModifierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Modifier value)
        {
            return value switch
            {
                Modifier.Idf => "idf",
                Modifier.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Modifier? ToEnum(string value)
        {
            return value switch
            {
                "idf" => Modifier.Idf,
                "none" => Modifier.None,
                _ => null,
            };
        }
    }
}