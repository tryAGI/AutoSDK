//HintName: G.Models.RetrievalStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RetrievalStrategy
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
    public static class RetrievalStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrievalStrategy value)
        {
            return value switch
            {
                RetrievalStrategy.Default => "default",
                RetrievalStrategy.AddNeighbors => "add_neighbors",
                RetrievalStrategy.FullDoc => "full_doc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrievalStrategy? ToEnum(string value)
        {
            return value switch
            {
                "default" => RetrievalStrategy.Default,
                "add_neighbors" => RetrievalStrategy.AddNeighbors,
                "full_doc" => RetrievalStrategy.FullDoc,
                _ => null,
            };
        }
    }
}