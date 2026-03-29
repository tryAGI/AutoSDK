//HintName: G.Models.DoclingComponentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DoclingComponentType
    {
        /// <summary>
        /// 
        /// </summary>
        DocAssembler,
        /// <summary>
        /// 
        /// </summary>
        DocumentBackend,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Pipeline,
        /// <summary>
        /// 
        /// </summary>
        UserInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DoclingComponentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DoclingComponentType value)
        {
            return value switch
            {
                DoclingComponentType.DocAssembler => "doc_assembler",
                DoclingComponentType.DocumentBackend => "document_backend",
                DoclingComponentType.Model => "model",
                DoclingComponentType.Pipeline => "pipeline",
                DoclingComponentType.UserInput => "user_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DoclingComponentType? ToEnum(string value)
        {
            return value switch
            {
                "doc_assembler" => DoclingComponentType.DocAssembler,
                "document_backend" => DoclingComponentType.DocumentBackend,
                "model" => DoclingComponentType.Model,
                "pipeline" => DoclingComponentType.Pipeline,
                "user_input" => DoclingComponentType.UserInput,
                _ => null,
            };
        }
    }
}