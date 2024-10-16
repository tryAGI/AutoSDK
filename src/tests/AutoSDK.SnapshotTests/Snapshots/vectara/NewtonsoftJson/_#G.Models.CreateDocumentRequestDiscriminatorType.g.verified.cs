//HintName: G.Models.CreateDocumentRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDocumentRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="core")]
        Core,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="structured")]
        Structured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDocumentRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDocumentRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateDocumentRequestDiscriminatorType.Core => "core",
                CreateDocumentRequestDiscriminatorType.Structured => "structured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDocumentRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "core" => CreateDocumentRequestDiscriminatorType.Core,
                "structured" => CreateDocumentRequestDiscriminatorType.Structured,
                _ => null,
            };
        }
    }
}