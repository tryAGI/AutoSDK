//HintName: G.Models.CreateAsyncEmbeddingRequestModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model you wish to use. Only `"marengo3.0"` is supported.<br/>
    /// Default Value: marengo3.0
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAsyncEmbeddingRequestModelName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marengo3.0")]
        Marengo30,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAsyncEmbeddingRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAsyncEmbeddingRequestModelName value)
        {
            return value switch
            {
                CreateAsyncEmbeddingRequestModelName.Marengo30 => "marengo3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAsyncEmbeddingRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "marengo3.0" => CreateAsyncEmbeddingRequestModelName.Marengo30,
                _ => null,
            };
        }
    }
}