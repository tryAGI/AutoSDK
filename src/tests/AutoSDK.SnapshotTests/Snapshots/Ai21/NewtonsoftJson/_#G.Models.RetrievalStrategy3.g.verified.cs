//HintName: G.Models.RetrievalStrategy3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RetrievalStrategy3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="add_neighbors")]
        AddNeighbors,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="full_doc")]
        FullDoc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetrievalStrategy3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrievalStrategy3 value)
        {
            return value switch
            {
                RetrievalStrategy3.Default => "default",
                RetrievalStrategy3.AddNeighbors => "add_neighbors",
                RetrievalStrategy3.FullDoc => "full_doc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrievalStrategy3? ToEnum(string value)
        {
            return value switch
            {
                "default" => RetrievalStrategy3.Default,
                "add_neighbors" => RetrievalStrategy3.AddNeighbors,
                "full_doc" => RetrievalStrategy3.FullDoc,
                _ => null,
            };
        }
    }
}