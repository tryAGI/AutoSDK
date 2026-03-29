//HintName: G.Models.ResponseFileCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the annotation. Always `file_citation`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFileCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_citation")]
        FileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFileCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFileCitationType value)
        {
            return value switch
            {
                ResponseFileCitationType.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFileCitationType? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => ResponseFileCitationType.FileCitation,
                _ => null,
            };
        }
    }
}