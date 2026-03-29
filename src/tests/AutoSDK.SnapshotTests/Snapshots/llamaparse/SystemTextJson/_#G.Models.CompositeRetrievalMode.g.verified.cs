//HintName: G.Models.CompositeRetrievalMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for the mode of composite retrieval.
    /// </summary>
    public enum CompositeRetrievalMode
    {
        /// <summary>
        /// 
        /// </summary>
        Full,
        /// <summary>
        /// 
        /// </summary>
        Routing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompositeRetrievalModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompositeRetrievalMode value)
        {
            return value switch
            {
                CompositeRetrievalMode.Full => "full",
                CompositeRetrievalMode.Routing => "routing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompositeRetrievalMode? ToEnum(string value)
        {
            return value switch
            {
                "full" => CompositeRetrievalMode.Full,
                "routing" => CompositeRetrievalMode.Routing,
                _ => null,
            };
        }
    }
}